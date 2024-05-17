using AutoMapper;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Group;

namespace Daskalo.Web.AutoMapperProfiles
{
    public class GroupAutoMapperProfile : Profile
    {
        public GroupAutoMapperProfile()
        {
            CreateMap<GroupCardViewModel, Group>();
        }
    }
}
