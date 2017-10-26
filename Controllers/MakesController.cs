using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vehicle_management.models;
using Vehicle_management.Persistence;

namespace Vehicle_management.Controllers
{
    public class MakesController:Controller
    {
        private readonly VehicleDbContext context;
        public MakesController(VehicleDbContext context)
        {
            this.context= context;
        }
        [HttpGet("/api/makes")]
        public async Task <IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m=>m.models).ToListAsync();
        }
        
    }
}