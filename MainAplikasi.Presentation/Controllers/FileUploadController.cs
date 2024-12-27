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
            throw new Exception("Begini");

            string htmlContent = "<html><body><h1>Welcome to the file upload page</h1></body></html>";
            return Content(htmlContent, "text/html");
        }
    }

    [Route("error")]
    [ApiController]
    public class ErrorHandlerController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPage()
        {
            string htmlContent = "<html><body><h1>Yakin lu?</h1></body></html>";
            return Content(htmlContent, "text/html");
        }
    }
}
