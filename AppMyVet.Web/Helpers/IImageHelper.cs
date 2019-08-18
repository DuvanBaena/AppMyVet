using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AppMyVet.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}