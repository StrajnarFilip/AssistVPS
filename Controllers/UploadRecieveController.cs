using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UploadFilesServer_VPS_assist.Controllers
{
    [Route("api/[controller]/{file_name}")]
    [ApiController]
    public class UploadRecieveController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadRecieve(string file_name)
        {
            if (Request.Cookies.Single(x => x.Key == "secure_password").Value == Program.securepassword){
                FileStream fileWrite = System.IO.File.OpenWrite(Path.Combine("uploads",file_name));
            await Request.Body.CopyToAsync(fileWrite);
            await fileWrite.FlushAsync();
            await fileWrite.DisposeAsync();
            return Ok();
            }
            else{
                System.Console.WriteLine("Secure password provided by client was not correct.");
                return Unauthorized();
            }
        }
    }
}