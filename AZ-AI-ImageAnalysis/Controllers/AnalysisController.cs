using AZ_AI_ImageAnalysis.Interfaces;
using AZ_AI_ImageAnalysis.Services;
using Microsoft.AspNetCore.Mvc;

namespace AZ_AI_ImageAnalysis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnalysisController(IVisionService visionService) : ControllerBase
    {
        [HttpPost("DenseCaptions")]
        public async Task<IActionResult> GetDenseCaptions([FromBody] string imageUrl)
        {
            var result = await visionService.GetDenseCaptionsAsync(imageUrl);
            return Content(result, "application/json");
        }

        [HttpPost("Caption")]
        public async Task<IActionResult> GetCaption([FromBody] string imageUrl)
        {
            var json = await visionService.GetCaptionAsync(imageUrl);
            return Content(json, "application/json");
        }

        [HttpPost("DetectObjects")]
        public async Task<IActionResult> DetectObjects([FromBody] string imageUrl)
        {
            var json = await visionService.DetectObjectsAsync(imageUrl);
            return Content(json, "application/json");
        }

        [HttpPost("ExtractTags")]
        public async Task<IActionResult> ExtractTags([FromBody] string imageUrl)
        {
            var json = await visionService.ExtractTagsAsync(imageUrl);
            return Content(json, "application/json");
        }
    }
}
