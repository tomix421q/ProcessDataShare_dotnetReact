using api.DbData;
using api.Interfaces.CollectToDb;
using api.Models.databaseModels.ASQ;
using S7.Net;

namespace api.Repository.DataToDB
{
    public class AsqDbDataRepo : IAsqDataDb
    {
        // DB
        private readonly ApplicationDBContext _context;

        public AsqDbDataRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        // IP ADRESS 
        private string _ipAddress_asq2;
        private string _ipAddress_asq3;
        private string _ipAddress_asq4;
        private string _ipAddress_asq5;
        private string _ipAddress_asq6;

        // DATA TO DB ASQ_2
        public async Task<Db_asq2Model> GetLiveDataToDb_asq2()
        {
            var asqModel = new Db_asq2Model();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1))
                {
                    plc.Open();
                    //actuall time
                    DateTime currentDate = DateTime.Now;
                    asqModel.TimeStamp = currentDate; //shot actual time                  
                    //ROB1
                    asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                    asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                    asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                    asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                    asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                    asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                    asqModel.ROB1_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW58.0")).ConvertToShort();
                    asqModel.ROB1_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD60.0")).ConvertToFloat();
                    //ROB2
                    asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                    asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                    asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                    asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                    asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                    asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                    asqModel.ROB2_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW64.0")).ConvertToShort();
                    asqModel.ROB2_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD66.0")).ConvertToFloat();
                    //Global
                    asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                    asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                    asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                    asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                    asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                }
            }
            catch (Exception ex)
            {
                return asqModel;

            }
            return asqModel;
        }

        // DATA TO DB ASQ_3
        public async Task<Db_asq3Model> GetLiveDataToDb_asq3()
        {
            var asqModel = new Db_asq3Model();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_asq3, 0, 1))
                {
                    plc.Open();
                    //actuall time
                    DateTime currentDate = DateTime.Now;
                    asqModel.TimeStamp = currentDate; //shot actual time                  
                    //ROB1
                    asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                    asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                    asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                    asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                    asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                    asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                    asqModel.ROB1_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW58.0")).ConvertToShort();
                    asqModel.ROB1_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD60.0")).ConvertToFloat();
                    //ROB2
                    asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                    asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                    asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                    asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                    asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                    asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                    asqModel.ROB2_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW64.0")).ConvertToShort();
                    asqModel.ROB2_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD66.0")).ConvertToFloat();
                    //Global
                    asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                    asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                    asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                    asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                    asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                }
            }
            catch (Exception ex)
            {
                return asqModel;

            }
            return asqModel;
        }

        // DATA TO DB ASQ_4
        public async Task<Db_asq4Model> GetLiveDataToDb_asq4()
        {
            var asqModel = new Db_asq4Model();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_asq4, 0, 1))
                {
                    plc.Open();
                    //actuall time
                    DateTime currentDate = DateTime.Now;
                    asqModel.TimeStamp = currentDate; //shot actual time                  
                    //ROB1
                    asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                    asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                    asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                    asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                    asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                    asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                    asqModel.ROB1_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW58.0")).ConvertToShort();
                    asqModel.ROB1_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD60.0")).ConvertToFloat();
                    //ROB2
                    asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                    asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                    asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                    asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                    asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                    asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                    asqModel.ROB2_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW64.0")).ConvertToShort();
                    asqModel.ROB2_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD66.0")).ConvertToFloat();
                    //Global
                    asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                    asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                    asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                    asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                    asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                }
            }
            catch (Exception ex)
            {
                return asqModel;

            }
            return asqModel;
        }


        // DATA TO DB ASQ_5
        public async Task<Db_asq5Model> GetLiveDataToDb_asq5()
        {
            var asqModel = new Db_asq5Model();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_asq5, 0, 1))
                {
                    plc.Open();
                    //actuall time
                    DateTime currentDate = DateTime.Now;
                    asqModel.TimeStamp = currentDate; //shot actual time                  
                    //ROB1
                    asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                    asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                    asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                    asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                    asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                    asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                    asqModel.ROB1_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW58.0")).ConvertToShort();
                    asqModel.ROB1_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD60.0")).ConvertToFloat();
                    //ROB2
                    asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                    asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                    asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                    asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                    asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                    asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                    asqModel.ROB2_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW64.0")).ConvertToShort();
                    asqModel.ROB2_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD66.0")).ConvertToFloat();
                    //Global
                    asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                    asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                    asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                    asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                    asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                }
            }
            catch (Exception ex)
            {
                return asqModel;

            }
            return asqModel;
        }


        // DATA TO DB ASQ_6
        public async Task<Db_asq6Model> GetLiveDataToDb_asq6()
        {
            var asqModel = new Db_asq6Model();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_asq6, 0, 1))
                {
                    plc.Open();
                    //actuall time
                    DateTime currentDate = DateTime.Now;
                    asqModel.TimeStamp = currentDate; //shot actual time                  
                    //ROB1
                    asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                    asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                    asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                    asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                    asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                    asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                    asqModel.ROB1_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW58.0")).ConvertToShort();
                    asqModel.ROB1_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD60.0")).ConvertToFloat();
                    //ROB2
                    asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                    asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                    asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                    asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                    asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                    asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                    asqModel.ROB2_ActStep = ((ushort)await plc.ReadAsync("DB179.DBW64.0")).ConvertToShort();
                    asqModel.ROB2_CycleTime = ((uint)await plc.ReadAsync("DB179.DBD66.0")).ConvertToFloat();
                    //Global
                    asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                    asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                    asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                    asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                    asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                }
            }
            catch (Exception ex)
            {
                return asqModel;

            }
            return asqModel;
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_asq2(string ipAddress)
        {
            _ipAddress_asq2 = ipAddress;
            try
            {
                using var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1);
                await plc.OpenAsync();//Connect
                if (plc.IsConnected)
                {
                    return (true, "Connection ASQ_2 OK"); // sucess
                }
                else
                {
                    return (false, "Unable connect ASQ_2 to PLC");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_2: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_asq3(string ipAddress)
        {
            _ipAddress_asq3 = ipAddress;
            try
            {
                using var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1);
                await plc.OpenAsync();//Connect
                if (plc.IsConnected)
                {
                    return (true, "Connection ASQ_3 OK"); // sucess
                }
                else
                {
                    return (false, "Unable connect ASQ_3 to PLC");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_3: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_asq4(string ipAddress)
        {
            _ipAddress_asq4 = ipAddress;
            try
            {
                using var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1);
                await plc.OpenAsync();//Connect
                if (plc.IsConnected)
                {
                    return (true, "Connection ASQ_4 OK"); // sucess
                }
                else
                {
                    return (false, "Unable connect ASQ_4 to PLC");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_4: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_asq5(string ipAddress)
        {
            _ipAddress_asq5 = ipAddress;
            try
            {
                using var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1);
                await plc.OpenAsync();//Connect
                if (plc.IsConnected)
                {
                    return (true, "Connection ASQ_5 OK"); // sucess
                }
                else
                {
                    return (false, "Unable connect ASQ_5 to PLC");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_5: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_asq6(string ipAddress)
        {
            _ipAddress_asq6 = ipAddress;
            try
            {
                using var plc = new Plc(CpuType.S71500, _ipAddress_asq2, 0, 1);
                await plc.OpenAsync();//Connect
                if (plc.IsConnected)
                {
                    return (true, "Connection ASQ_6 OK"); // sucess
                }
                else
                {
                    return (false, "Unable connect ASQ_6 to PLC");
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_6: {ex.Message}");
            }
        }
    }
}