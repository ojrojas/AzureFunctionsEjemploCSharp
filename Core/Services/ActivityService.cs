using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.BaseHttp.HttpMessages.Activity;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public class ActivityService : IActivityService
    {
        private readonly IAsyncRepository<Activity> _asyncRepository;
        private readonly ILogger<ActivityService> _logger;
        private readonly IMapper _mapper;

        public ActivityService(IAsyncRepository<Activity> asyncRepository, ILogger<ActivityService> logger, IMapper mapper)
        {
            _asyncRepository = asyncRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<CreateActivityResponse> CreateActivityAsync(CreateActivityRequest activityRequest)
        {
            var response = new CreateActivityResponse(activityRequest.CorrelationId);
            var activity = await _asyncRepository.CreateAsync(_mapper.Map<Activity>(activityRequest));
            response.ActivityDto = _mapper.Map<ActivityDto>(activity);
            return response;
        }

        public async Task<UpdateActivityResponse> UpdateActivityAsync(UpdateActivityRequest activityRequest)
        {
            var response = new UpdateActivityResponse(activityRequest.CorrelationId);
            var activity = await _asyncRepository.CreateAsync(_mapper.Map<Activity>(activityRequest));
            response.ActivityDto = _mapper.Map<ActivityDto>(activity);
            return response;
        }

        public async Task<GetActivityByIdResponse> GetActivityByIdAsync(GetActivityByIdRequest activityRequest)
        {
            var response = new GetActivityByIdResponse(activityRequest.CorrelationId);
            var activity = await _asyncRepository.CreateAsync(_mapper.Map<Activity>(activityRequest));
            response.ActivityDto = _mapper.Map<ActivityDto>(activity);
            return response;
        }

        public async Task<GetActivitiesResponse> GetActivitiesAsync(GetActivitiesRequest activityRequest)
        {
            var response = new GetActivitiesResponse(activityRequest.CorrelationId);
            var activity = await _asyncRepository.CreateAsync(_mapper.Map<Activity>(activityRequest));
            response.Activities = _mapper.Map<List<ActivityDto>>(activity);
            return response;
        }
    }
}