using api.Interfaces.Live;
using api.Models;
using S7.Net;


namespace api.Repository
{
    public class AsqLiveDataRepo : IAsqLiveDataService
    {
        private string _ipAddress;

        // 
        // READ DATA
        // 
        public async Task<AsqModel> GetAsqLiveData()
        {
            var asqModel = new AsqModel();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        asqModel.connection = "Connection OK";

                        //ROB1
                        asqModel.ROB1_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW0.0")).ConvertToShort();
                        asqModel.ROB1_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW2.0")).ConvertToShort();
                        asqModel.ROB1_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD4.0")).ConvertToFloat();
                        asqModel.ROB1_Temperature = ((uint)await plc.ReadAsync("DB179.DBD8.0")).ConvertToFloat();
                        asqModel.ROB1_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD12.0")).ConvertToFloat();
                        asqModel.ROB1_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD16.0")).ConvertToFloat();
                        //ROB2
                        asqModel.ROB2_Downtime_Time = ((ushort)await plc.ReadAsync("DB179.DBW20.0")).ConvertToShort();
                        asqModel.ROB2_FormNumber = ((ushort)await plc.ReadAsync("DB179.DBW22.0")).ConvertToShort();
                        asqModel.ROB2_WeightActualValue = ((uint)await plc.ReadAsync("DB179.DBD24.0")).ConvertToFloat();
                        asqModel.ROB2_Temperature = ((uint)await plc.ReadAsync("DB179.DBD28.0")).ConvertToFloat();
                        asqModel.ROB2_SetTemperature = ((uint)await plc.ReadAsync("DB179.DBD32.0")).ConvertToFloat();
                        asqModel.ROB2_TimeDrying = ((uint)await plc.ReadAsync("DB179.DBD36.0")).ConvertToFloat();
                        //Global
                        asqModel.Global_RefValue = ((uint)await plc.ReadAsync("DB179.DBD40.0")).ConvertToFloat();
                        asqModel.Global_WeightTolMinus = ((uint)await plc.ReadAsync("DB179.DBD44.0")).ConvertToFloat();
                        asqModel.Global_WeightTolPlus = ((uint)await plc.ReadAsync("DB179.DBD48.0")).ConvertToFloat();
                        asqModel.Global_GoWeightAfter = ((ushort)await plc.ReadAsync("DB179.DBW52.0")).ConvertToShort();
                        asqModel.Global_MixingTime = ((uint)await plc.ReadAsync("DB179.DBD54.0")).ConvertToFloat();
                    }
                    else
                    {
                        asqModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                asqModel.connection = $"Error: {ex.Message}";
            }

            return asqModel;
        }

        // 
        // CHECK IP ADRESS CONNECT
        // 
        public async Task<(bool success, string errorMessage)> SetIpAddress(string ipAddress)
        {
            _ipAddress = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection OK"); // Úspěšně nastaveno
                    }
                    else
                    {
                        return (false, "Unable to connect to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error: {ex.Message}");
            }
        }



    }
}