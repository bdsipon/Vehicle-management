using Microsoft.AspNetCore.Mvc;
using Vehicle_management.models;

namespace Vehicle_management.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesController:Controller
    {
        [HttpPost]
        public IActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(vehicle);

        }
        
    }
}