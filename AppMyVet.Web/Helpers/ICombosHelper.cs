using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace AppMyVet.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboPetTypes();
    }
}