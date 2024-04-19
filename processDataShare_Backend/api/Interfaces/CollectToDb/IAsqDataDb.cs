using api.Models;
using api.Models.databaseModels.ASQ;

namespace api.Interfaces.CollectToDb
{
    public interface IAsqDataDb
    {
        //_______________________ASQ_2________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq2(string ipAddress);
        Task<Db_asq2Model> GetLiveDataToDb_asq2();
        //_______________________ASQ_3________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq3(string ipAddress);
        Task<Db_asq3Model> GetLiveDataToDb_asq3();
        //_______________________ASQ_4________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq4(string ipAddress);
        Task<Db_asq4Model> GetLiveDataToDb_asq4();
        //_______________________ASQ_5________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq5(string ipAddress);
        Task<Db_asq5Model> GetLiveDataToDb_asq5();
        //_______________________ASQ_6________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq6(string ipAddress);
        Task<Db_asq6Model> GetLiveDataToDb_asq6();
    }
}