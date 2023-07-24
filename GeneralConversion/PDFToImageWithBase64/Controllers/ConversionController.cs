using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PDFToImageWithBase64.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionController : ControllerBase
    {
        // POST api/<ConversionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
