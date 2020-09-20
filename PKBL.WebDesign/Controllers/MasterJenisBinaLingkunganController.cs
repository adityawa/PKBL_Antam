using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PKBL.WebDesign.Controllers
{
    public class MasterJenisBinaLingkunganController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
