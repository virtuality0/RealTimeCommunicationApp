using RealTimeCommunicationApp.DAL.Models.RequestModels;
using RealTimeCommunicationApp.DAL.Models.ResponseModels;
using RealTimeCommunicationApp.Services.Interfaces;

namespace RealTimeCommunicationApp.Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<RegisterUserResponseModel> RegisterAsync(RegisterUserRequestModel response)
        {
            throw new NotImplementedException();
        }
    }
}
