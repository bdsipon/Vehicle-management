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
            CreateMap<Vehicle,VehicleResource>()
            .ForMember(vr=>vr.contact,opt=>opt.MapFrom(v=>new ContactResource{Name=v.ContactName,Email=v.ContactEmail,Phone=v.ContactPhone}))
            .ForMember(vr=>vr.Features,opt=>opt.MapFrom(v=>v.Features.Select(vf=>vf.FeatureId)));
            

            CreateMap<VehicleResource,Vehicle>()
            .ForMember(v => v.ContactName,opt=>opt.MapFrom(vr =>vr.contact.Name))
             .ForMember(v => v.ContactEmail,opt=>opt.MapFrom(vr =>vr.contact.Email))
              .ForMember(v => v.ContactPhone,opt=>opt.MapFrom(vr =>vr.contact.Phone))
               .ForMember(v => v.Features,opt=>opt.MapFrom(vr =>vr.Features.Select(id=>new VehicleFeature{FeatureId=id})));
        }
    }
}