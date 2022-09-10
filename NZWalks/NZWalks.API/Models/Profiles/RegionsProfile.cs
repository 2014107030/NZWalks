using AutoMapper;

namespace NZWalks.API.Models.Profiles
{
    public class RegionsProfile : Profile
    {
        public RegionsProfile()
        {
            CreateMap<Domain.Region, DTO.Region>()
                //.ForMember(dest => dest.Id, options => options.MapFrom(src => src.RegionId)); -- useed in case the model and dto variables are different
                .ReverseMap();

        }
    }
}
