using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Vehicle_management.Controllers.Resources;
using Vehicle_management.models;

namespace Vehicle_management.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController:Controller
    {
        private readonly IMapper mapper;
        public  VehiclesController (IMapper  mapper)  
        {
            this.mapper=mapper;
           
        }

        public IMapper Mapper { get; }

        [HttpPost]
        public IActionResult CreateVehicle([FromBody] VehicleResource vehicleResource)
        {
            var vehicle=mapper.Map<VehicleResource,Vehicle>(vehicleResource);
            return Ok(vehicle);

        }
        
    }
}