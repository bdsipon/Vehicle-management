using AutoMapper;
using Vehicle_management.Controllers.Resources;
using Vehicle_management.models;
using System.Linq;

namespace Vehicle_management.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            //Domain to Api Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model,ModelResouce>();
            CreateMap<Feature,FeatureResource>();
            

            CreateMap<VehicleResource,Vehicle>()
            .ForMember(v => v.ContactName,opt=>opt.MapFrom(vr =>vr.Contact.Name))
             .ForMember(v => v.ContactEmail,opt=>opt.MapFrom(vr =>vr.Contact.Email))
              .ForMember(v => v.ContactPhone,opt=>opt.MapFrom(vr =>vr.Contact.Phone))
               .ForMember(v => v.Features,opt=>opt.MapFrom(vr =>vr.Features.Select(id=>new VehicleFeature{FeatureId=id})));
        }
    }
}