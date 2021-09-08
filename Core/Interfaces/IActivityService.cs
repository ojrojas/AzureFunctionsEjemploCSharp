using System.Threading.Tasks;
using Core.BaseHttp.HttpMessages.Activity;

namespace Core.Interfaces
{
    public interface IActivityService
    {
        Task<CreateActivityResponse> CreateActivityAsync(CreateActivityRequest activityRequest);
        Task<GetActivitiesResponse> GetActivitiesAsync(GetActivitiesRequest activityRequest);
        Task<GetActivityByIdResponse> GetActivityByIdAsync(GetActivityByIdRequest activityRequest);
        Task<UpdateActivityResponse> UpdateActivityAsync(UpdateActivityRequest activityRequest);
    }
}