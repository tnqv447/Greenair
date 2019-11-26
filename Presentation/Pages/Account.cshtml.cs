using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Presentation.Helpers;

namespace Presentation.Pages
{
    public class AccountModel : PageModel
    {
        [BindProperty]
        public string From { get; set; }
        [BindProperty]
        public string Where { get; set; }
        [BindProperty]
        public string DepDate { get; set; }
        [BindProperty]
        public string ArrDate { get; set; }
        [BindProperty]
        public string NumAdults { get; set; }
        [BindProperty]
        public string NumChilds { get; set; }
        [BindProperty]
        public string FlightType { get; set; }
        private readonly ILogger<AccountModel> _logger;

        public AccountModel(ILogger<AccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
         public IActionResult OnPost()
        {
            var FlightSearch = new Dictionary<string,object>();
            FlightSearch.Add("from",From);
            FlightSearch.Add("where",Where);
            FlightSearch.Add("depdate",DepDate);
            FlightSearch.Add("arrdate",ArrDate);
            FlightSearch.Add("type",FlightType);
            FlightSearch.Add("adults",NumAdults);
            FlightSearch.Add("childs",NumChilds);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "FlightSearch", FlightSearch);
            return RedirectToPage("Flight");
        }
    }
}
