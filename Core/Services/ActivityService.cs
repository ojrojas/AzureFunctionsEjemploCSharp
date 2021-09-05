using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public class ActivityService
    {
        private readonly IAsyncRepository<Activity> _asyncRepository;
        private readonly ILogger<ActivityService> _logger;

        public ActivityService(IAsyncRepository<Activity> asyncRepository, ILogger<ActivityService> logger)
        {
            _asyncRepository = asyncRepository;
            _logger = logger;
        }
    }
}