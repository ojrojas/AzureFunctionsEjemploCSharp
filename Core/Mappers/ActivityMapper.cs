using AutoMapper;
using Core.BaseHttp.HttpMessages.Activity;
using Core.Dtos;
using Core.Entities;

namespace Core.Mappers
{
    public class ActivityMappers : Profile
    {
        public ActivityMappers()
        {
            CreateMap<Activity, CreateActivityRequest>();
            CreateMap<Activity, ActivityDto>();
        }
    }
}