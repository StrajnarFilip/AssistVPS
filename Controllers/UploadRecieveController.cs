using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            FileStream fileWrite=System.IO.File.OpenWrite(file_name);
            await Request.Body.CopyToAsync(fileWrite);
            await fileWrite.FlushAsync();
            await fileWrite.DisposeAsync();
            return Ok();
        }
    }
}