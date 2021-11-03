using Encurtador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Encurtador.Controllers
{

    // This will be needed later in the PostURL() method
    public class URLResponse
    {
        public string url { get; set; }
        public string status { get; set; }
        public string token { get; set; }
    }


    public class HomeController : Controller
    {



        // Our index Route
        [HttpGet, Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        // Our URL shorten route
        [HttpPost, Route("/")]
        public IActionResult PostURL([FromBody] string url)
        {
            throw new NotImplementedException();
        }

        // Our Redirect route
        [HttpGet, Route("/{token}")]
        public IActionResult NixRedirect([FromRoute] string token)
        {
            throw new NotImplementedException();

        }

       
        
    }
}
