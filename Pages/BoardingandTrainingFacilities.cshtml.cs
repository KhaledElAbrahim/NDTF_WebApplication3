using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class BoardingandTrainingFacilitiesModel : PageModel
    {

        #region
        [BindProperty]
        public ContactViewModel CVM { get; set; }
        [BindProperty]
        public NewsletterFormViewModel NVM { get; set; }
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
    }
}