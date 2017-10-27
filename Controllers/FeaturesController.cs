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
    public class FeaturesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VehicleDbContext context;
        public FeaturesController(VehicleDbContext context, IMapper mapper)
        {
            this.context = context;

            this.mapper = mapper;
        }
        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features =await context.Features.ToListAsync();
            return mapper.Map<List<Feature>,List<FeatureResource>>(features);
            
        }

    }
}