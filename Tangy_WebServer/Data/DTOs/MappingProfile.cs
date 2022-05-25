using AutoMapper;

namespace Tangy_WebServer.Data.DTOs.MappingProfile;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category,CategoryDTO>().ReverseMap();
    }
}