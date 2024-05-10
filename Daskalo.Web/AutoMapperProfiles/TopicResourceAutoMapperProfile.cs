using AutoMapper;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Resource;

namespace Daskalo.Web.AutoMapperProfiles
{
    public class TopicResourceAutoMapperProfile : Profile
    {
        public TopicResourceAutoMapperProfile()
        {
            CreateMap<ResourceFormViewModel, TopicResource>().ForMember(
                dest => dest.Id, 
                opt => opt.NullSubstitute(Guid.NewGuid().ToString()))
                .ReverseMap();
        }
    }
}
