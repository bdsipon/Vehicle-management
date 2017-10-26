using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vehicle_management.Controllers.Resources;
using Vehicle_management.models;
using Vehicle_management.Persistence;

namespace Vehicle_management.Controllers
{
    public class MakesController : Controller
    {
        private readonly VehicleDbContext context;
        private readonly IMapper mapper;
        public MakesController(VehicleDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
           var makes= await context.Makes.Include(m => m.models).ToListAsync();
           return mapper.Map<List<Make>,List<MakeResource>>(makes);
        }

    }
}