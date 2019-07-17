using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class ObedienceTrainersSchoolsModel : PageModel
    {
        #region Variables
        [BindProperty]
        public ContactViewModel CVM { get; set; }
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

        public void OnGet()
        {

        }
    }
}