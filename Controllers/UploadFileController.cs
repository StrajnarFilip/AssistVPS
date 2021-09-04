using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UploadFilesServer_VPS_assist.Controllers
{
    public class UploadFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}