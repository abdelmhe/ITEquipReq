using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ITEquipReq.Views.Home
{
    public class RequestForm : PageModel
    {
        private readonly ILogger<RequestForm> _logger;

        public RequestForm(ILogger<RequestForm> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}