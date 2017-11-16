using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vehicle_management.Controllers.Resources;
using Vehicle_management.models;

using Vehicle_management.Persistence;

namespace Vehicle_management.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VehicleDbContext context;
        public VehiclesController(IMapper mapper, VehicleDbContext context)
        {
            this.context = context;
            this.mapper = mapper;

        }

        public IMapper Mapper { get; }

        [HttpPost]
        public async Task<IActionResult> CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            if(!ModelState.IsValid)
            return BadRequest(ModelState);
     
            var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
            vehicle.LastUpdate=DateTime.Now;

            context.Vehicles.Add(vehicle);
            await context.SaveChangesAsync();
var result=mapper.Map<Vehicle,VehicleResource>(vehicle);
            return Ok(result);

        }

    }
}