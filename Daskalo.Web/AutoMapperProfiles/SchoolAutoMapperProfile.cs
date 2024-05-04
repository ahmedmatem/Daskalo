using AutoMapper;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Admin.ViewModels;

namespace Daskalo.Web.AutoMapperProfiles
{
    public class SchoolAutoMapperProfile : Profile
    {
        public SchoolAutoMapperProfile()
        {
            CreateMap<SchoolFormViewModel, School>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(
                    src => string.IsNullOrEmpty(src.Id) ? Guid.NewGuid().ToString() : src.Id))
                .ReverseMap();
        }
    }
}
