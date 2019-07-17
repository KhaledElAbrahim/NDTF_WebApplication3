using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {

        #region Variables
        [BindProperty]
        public NewsletterFormViewModel NVM { get; set; }
        #endregion

        #region NewsletterForm View Model
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
