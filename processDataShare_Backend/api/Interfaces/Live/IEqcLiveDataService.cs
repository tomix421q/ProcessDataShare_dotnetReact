using api.Models;

namespace api.Interfaces.Live
{
    public interface IEqcLiveDataService
    {
        Task<(bool success, string errorMessage)> SetIpAddress(string ipAddress);
        Task<EqcModel> GetEqcLiveData();
    }
}