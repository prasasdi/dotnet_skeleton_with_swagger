using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainAplikasi.Presentation.Controllers
{
    [Route("api/file")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        /// <summary>
        /// Retrieves a specific product by unique id
        /// </summary>
        /// <remarks>
        /// terlepas dari ukuran sebuah file yang diupload berukuran besar atau kecil, yang ada akan di potong/cacah perchunk
        /// </remarks>
        /// <response code="200">Product created</response>
        /// <response code="400">Product has missing/invalid values</response>
        /// <response code="500">Oops! Can't create your product right now</response>
        [HttpPost]
        [Route("upload")]
        public IActionResult UploadFile([FromBody] IFormFile file)
        {
            return Ok();
        }
        [HttpGet]
        [Route("index")]
        public IActionResult GetPage()
        {
            return Ok("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>@ViewData[\"Title\"] - Your App Name</title>\r\n    <link rel=\"stylesheet\" href=\"~/css/site.css\" />\r\n</head>\r\n<body>\r\n    <div>\r\n        <h1>Hello, world!</h1>\r\n        <p>Welcome to your ASP.NET Core application.</p>\r\n    </div>\r\n    <script src=\"~/js/site.js\"></script>\r\n</body>\r\n</html>");
        }
    }
}
