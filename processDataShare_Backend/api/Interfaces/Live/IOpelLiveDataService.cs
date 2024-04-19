using api.Models;

namespace api.Interfaces.Live
{
    public interface IOpelLiveDataService
    {
        Task<(bool success, string errorMessage)> SetIpAddress(string ipAddress);
        Task<OpelArmrestModel> GetOpelArmrestLiveData();
        Task<OpelInsertModel> GetOpelInsertLiveData();
    }
}