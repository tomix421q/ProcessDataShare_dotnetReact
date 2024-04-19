using api.Helpers;
using api.Models.databaseModels.ASQ;
using api.Models.databaseModels.EQC;

namespace api.Interfaces.CollectFromDb
{
    public interface IDataFromDb
    {
        Task<int> GetNumRecords();

        //EQC MF DB
        Task<List<Db_eqc1Model>> GetAllEqc1Async(QueryObject query);
        Task<List<Db_eqc2Model>> GetAllEqc2Async(QueryObject query);
        Task<List<Db_eqc3Model>> GetAllEqc3Async(QueryObject query);
        Task<List<Db_eqc4Model>> GetAllEqc4Async(QueryObject query);
        Task<List<Db_eqc5Model>> GetAllEqc5Async(QueryObject query);
        Task<List<Db_eqc6Model>> GetAllEqc6Async(QueryObject query);
        Task<List<Db_eqc7Model>> GetAllEqc7Async(QueryObject query);
        Task<List<Db_eqc8Model>> GetAllEqc8Async(QueryObject query);

        //ASQ DB
        Task<List<Db_asq2Model>> GetAllAsq2Async(QueryObject query);
        Task<List<Db_asq3Model>> GetAllAsq3Async(QueryObject query);
        Task<List<Db_asq4Model>> GetAllAsq4Async(QueryObject query);
        Task<List<Db_asq5Model>> GetAllAsq5Async(QueryObject query);
        Task<List<Db_asq6Model>> GetAllAsq6Async(QueryObject query);

    }
}