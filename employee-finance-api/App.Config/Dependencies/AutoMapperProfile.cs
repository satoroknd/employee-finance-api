using AutoMapper;

namespace App.Config.Dependencies
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            ///Example Mapping
            //CreateMap<CustomerEntity, CustomerContract>()
            //.ForMember(dest => dest.CustomerID, opt => opt.MapFrom(src => src.CustomerID))
            //.ReverseMap();
        }
    }
}
