﻿using AutoMapper;
using Daskalo.Infrastructure.Data.Models;
using Daskalo.Web.Areas.Teacher.Models.Topic;

namespace Daskalo.Web.AutoMapperProfiles
{
    public class TopicAutoMapperProfile : Profile
    {
        public TopicAutoMapperProfile()
        {
            CreateMap<TopicFormViewModel, Topic>()
                .ForMember(dest => dest.Id, opt =>
                    opt.MapFrom(src => string.IsNullOrEmpty(src.Id) ? Guid.NewGuid().ToString() : src.Id));
        }
    }
}
