using RealTimeCommunicationApp.DAL.Models.RequestModels;
using RealTimeCommunicationApp.DAL.Models.ResponseModels;

namespace RealTimeCommunicationApp.Services.Interfaces
{
    public interface IUserService
    {
        public Task<RegisterUserResponseModel> RegisterAsync(RegisterUserRequestModel response);
    }
}
