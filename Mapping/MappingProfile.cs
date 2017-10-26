using AutoMapper;
using Vehicle_management.Controllers.Resources;
using Vehicle_management.models;

namespace Vehicle_management.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model,ModelResouce>();
        }
    }
}