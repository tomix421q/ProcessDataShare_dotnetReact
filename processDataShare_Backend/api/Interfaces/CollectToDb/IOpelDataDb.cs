using api.Models.databaseModels.OPEL;

namespace api.Interfaces.CollectToDb
{
    public interface IOpelDataDb
    {
        //______________________OPEL-ARMREST-FR______________________
        Task<(bool success, string errorMessage)> SetIpAddress_opelArmrest_Fr(string ipAddress);
        Task<Db_ArmrestFr> GetLiveDataToDb_opelArmrest_Fr();

        //______________________OPEL-ARMREST-RR______________________
        Task<(bool success, string errorMessage)> SetIpAddress_opelArmrest_Rr(string ipAddress);
        Task<Db_ArmrestRr> GetLiveDataToDb_opelArmrest_Rr();

        //______________________OPEL-INSERT-FR______________________
        // Task<(bool success, string errorMessage)> SetIpAddress_opelInsert_Fr(string ipAddress);
        // Task<Db_ArmrestFr> GetLiveDataToDb_opelInsert_Fr();

        //______________________OPEL-INSERT-RR______________________
        // Task<(bool success, string errorMessage)> SetIpAddress_opelInsert_Rr(string ipAddress);
        // Task<Db_ArmrestFr> GetLiveDataToDb_opelInsert_Rr();
    }
}