using System.Threading.Tasks;
using AppMyVet.Web.Data.Entities;
using AppMyVet.Web.Models;

namespace AppMyVet.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);

        PetViewModel ToPetViewModel(Pet pet);
    }
}