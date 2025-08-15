using Newtonsoft.Json.Linq;

namespace AZ_AI_ImageAnalysis.Interfaces
{
    public interface IVisionService
    {
        Task<string> GetDenseCaptionsAsync(string imageUrl);

        Task<string> GetCaptionAsync(string imageUrl);

        Task<string> DetectObjectsAsync(string imageUrl);

        Task<string> ExtractTagsAsync(string imageUrl);
    }
}
