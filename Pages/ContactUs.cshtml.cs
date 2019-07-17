using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication3.Models;
using WebApplication3.Services;

namespace WebApplication3.Pages.ContactUs
{
    public class ContactUsModel : PageModel
    {
        #region Variable
        [BindProperty]
        public ContactViewModel CVM { get; set; }
        [BindProperty]
        public NewsletterFormViewModel NVM { get; set; }
        private IContactRepository _contactRepo;
        #endregion

        #region Constructor
        public ContactUsModel(IContactRepository contactRepository)
        {
            _contactRepo = contactRepository;
        }
        #endregion

        #region Contact View Model
        public class ContactViewModel
        {
            public string Fullname { get; set; }
            public string Email { get; set; }
            public string Subject { get; set; }
            public string Message { get; set; }
        }
        #endregion

        #region NewsletterFormViewModel
        public class NewsletterFormViewModel
        {
            public string Email { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }
        #endregion

        public void OnGet()
        {

        }

        #region On Post Add
        public IActionResult OnPostAdd()
        {
            if (ModelState.IsValid)
            {
                ContactForm c = new ContactForm()
                {
                    Fullname = CVM.Fullname,
                    Email = CVM.Email,
                    Subject = CVM.Subject,
                    Message = CVM.Message
                };
                _contactRepo.Create(c);
                return Page();
            }
            return Page();
        }
        #endregion

    }
}