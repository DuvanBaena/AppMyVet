using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppMyVet.Web.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AppMyVet.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PetTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public PetTypesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<PetType> GetPetTypes()
        {
            return _context.PetTypes;
        }
 
    }
}