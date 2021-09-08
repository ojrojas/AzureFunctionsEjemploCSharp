using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.Extensions.Logging;

namespace Core.Services
{
    public  class UserService: IUserService
    {
        private readonly ILogger<UserService> _logger;
        private readonly IAsyncRepository<User> _asyncRepository;
        private readonly IMapper _mapper;

        public UserService(ILogger<UserService> logger,
            IAsyncRepository<User> asyncRepository,
            IMapper mapper)
        {
            _logger = logger;
            _asyncRepository = asyncRepository;
            _mapper = mapper;
        }
    }
}