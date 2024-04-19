using api.Models;

namespace api.Interfaces.Live
{
    public interface IAsqLiveDataService
    {
        Task<(bool success, string errorMessage)> SetIpAddress(string ipAddress);
        Task<AsqModel> GetAsqLiveData();
    }
}