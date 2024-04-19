using api.Interfaces.Live;
using api.Models;
using S7.Net;

namespace api.Repository
{
    public class MainLiveDataService : IMainLiveDataService
    {
        //MODEL
        private class PlcResult
        {
            public int Value { get; set; }
            public string Connection { get; set; }
        }

        //READ DATA
        public async Task<HomeDashboardModel> GetDashboardData()
        {
            var DashboardModel = new HomeDashboardModel();

            //___________________________________ASQ_____________________________________
            // PlcResult asq1A_result = await ReadDowntimeFromPlcAsync("10.184.159.241", "DB179.DBW0.0");
            // PlcResult asq1B_result = await ReadDowntimeFromPlcAsync("10.184.159.241", "DB179.DBW20.0");
            // DashboardModel.ASQ_1_ROB1_Downtime_Time = asq1A_result.Value;
            // DashboardModel.ASQ_1_ROB2_Downtime_Time = asq1B_result.Value;
            // DashboardModel.connectionAsq1 = asq1A_result.Connection;

            PlcResult asq2A_result = await ReadDowntimeFromPlcAsync("10.184.159.109", "DB179.DBW0.0");
            PlcResult asq2B_result = await ReadDowntimeFromPlcAsync("10.184.159.109", "DB179.DBW20.0");
            DashboardModel.ASQ_2_ROB1_Downtime_Time = asq2A_result.Value;
            DashboardModel.ASQ_2_ROB2_Downtime_Time = asq2B_result.Value;
            DashboardModel.connectionAsq2 = asq2A_result.Connection;

            PlcResult asq3A_result = await ReadDowntimeFromPlcAsync("10.184.159.240", "DB179.DBW0.0");
            PlcResult asq3B_result = await ReadDowntimeFromPlcAsync("10.184.159.240", "DB179.DBW20.0");
            DashboardModel.ASQ_3_ROB1_Downtime_Time = asq3A_result.Value;
            DashboardModel.ASQ_3_ROB2_Downtime_Time = asq3B_result.Value;
            DashboardModel.connectionAsq3 = asq3A_result.Connection;

            PlcResult asq4A_result = await ReadDowntimeFromPlcAsync("10.184.159.12", "DB179.DBW0.0");
            PlcResult asq4B_result = await ReadDowntimeFromPlcAsync("10.184.159.12", "DB179.DBW20.0");
            DashboardModel.ASQ_4_ROB1_Downtime_Time = asq4A_result.Value;
            DashboardModel.ASQ_4_ROB2_Downtime_Time = asq4B_result.Value;
            DashboardModel.connectionAsq4 = asq4A_result.Connection;

            PlcResult asq5A_result = await ReadDowntimeFromPlcAsync("10.184.159.108", "DB179.DBW0.0");
            PlcResult asq5B_result = await ReadDowntimeFromPlcAsync("10.184.159.108", "DB179.DBW20.0");
            DashboardModel.ASQ_5_ROB1_Downtime_Time = asq5A_result.Value;
            DashboardModel.ASQ_5_ROB2_Downtime_Time = asq5B_result.Value;
            DashboardModel.connectionAsq5 = asq5A_result.Connection;

            PlcResult asq6A_result = await ReadDowntimeFromPlcAsync("10.184.159.184", "DB179.DBW0.0");
            PlcResult asq6B_result = await ReadDowntimeFromPlcAsync("10.184.159.184", "DB179.DBW20.0");
            DashboardModel.ASQ_6_ROB1_Downtime_Time = asq6A_result.Value;
            DashboardModel.ASQ_6_ROB2_Downtime_Time = asq6B_result.Value;
            DashboardModel.connectionAsq6 = asq6A_result.Connection;
            //________________________________OPEL____________________________________
            PlcResult opelArmrestFD_result = await ReadDowntimeFromPlcAsync("10.184.159.45", "DB26.DBW0.0");
            DashboardModel.OpelArmrestFD_actualDowntime = opelArmrestFD_result.Value;
            DashboardModel.connectionOpelArmrestFd = opelArmrestFD_result.Connection;

            PlcResult opelArmrestRD_result = await ReadDowntimeFromPlcAsync("10.184.159.46", "DB26.DBW0.0");
            DashboardModel.OpelArmrestRD_actualDowntime = opelArmrestRD_result.Value;
            DashboardModel.connectionOpelArmrestRd = opelArmrestRD_result.Connection;

            PlcResult opelInsertFD_result = await ReadDowntimeFromPlcAsync("10.184.159.48", "DB26.DBW0.0");
            DashboardModel.OpelInsertFD_actualDowntime = opelInsertFD_result.Value;
            DashboardModel.connectionOpelInsertFd = opelInsertFD_result.Connection;

            PlcResult opelInsertRD_result = await ReadDowntimeFromPlcAsync("10.184.159.47", "DB26.DBW0.0");
            DashboardModel.OpelInsertRD_actualDowntime = opelInsertRD_result.Value;
            DashboardModel.connectionOpelInsertRd = opelInsertRD_result.Connection;
            //__________________________________MFEQC___________________________________
            PlcResult MF1_result = await ReadDowntimeFromPlcAsync("10.184.159.173", "DB189.DBW0.0");
            DashboardModel.EqcMF1_actualDownTime = MF1_result.Value;
            DashboardModel.connectionEqcMF1 = MF1_result.Connection;

            PlcResult MF2_result = await ReadDowntimeFromPlcAsync("10.184.159.174", "DB189.DBW0.0");
            DashboardModel.EqcMF2_actualDownTime = MF2_result.Value;
            DashboardModel.connectionEqcMF2 = MF2_result.Connection;

            PlcResult MF3_result = await ReadDowntimeFromPlcAsync("10.184.159.175", "DB189.DBW0.0");
            DashboardModel.EqcMF3_actualDownTime = MF3_result.Value;
            DashboardModel.connectionEqcMF3 = MF3_result.Connection;

            PlcResult MF4_result = await ReadDowntimeFromPlcAsync("10.184.159.176", "DB189.DBW0.0");
            DashboardModel.EqcMF4_actualDownTime = MF4_result.Value;
            DashboardModel.connectionEqcMF4 = MF4_result.Connection;

            PlcResult MF5_result = await ReadDowntimeFromPlcAsync("10.184.159.89", "DB189.DBW0.0");
            DashboardModel.EqcMF5_actualDownTime = MF5_result.Value;
            DashboardModel.connectionEqcMF5 = MF5_result.Connection;

            PlcResult MF6_result = await ReadDowntimeFromPlcAsync("10.184.159.99", "DB189.DBW0.0");
            DashboardModel.EqcMF6_actualDownTime = MF6_result.Value;
            DashboardModel.connectionEqcMF6 = MF6_result.Connection;

            PlcResult MF7_result = await ReadDowntimeFromPlcAsync("10.184.159.171", "DB189.DBW0.0");
            DashboardModel.EqcMF7_actualDownTime = MF7_result.Value;
            DashboardModel.connectionEqcMF7 = MF7_result.Connection;

            PlcResult MF8_result = await ReadDowntimeFromPlcAsync("10.184.159.101", "DB189.DBW0.0");
            DashboardModel.EqcMF8_actualDownTime = MF8_result.Value;
            DashboardModel.connectionEqcMF8 = MF8_result.Connection;

            PlcResult G26_result = await ReadDowntimeFromPlcAsync("10.184.159.211", "DB80.DBW0.0");
            DashboardModel.G26Bmw = G26_result.Value;
            DashboardModel.connectionG26 = G26_result.Connection;

            // ... 


            return DashboardModel;
        }

        //CONNECTIVITY
        private async Task<PlcResult> ReadDowntimeFromPlcAsync(string ipAddress, string dbAddress)
        {
            PlcResult result = new PlcResult();

            try
            {
                using (var plc = new Plc(CpuType.S71500, ipAddress, 0, 1))
                {
                    var timeoutTask = Task.Delay(40000);
                    var openTask = plc.OpenAsync();
                    await Task.WhenAny(openTask, timeoutTask);
                    if (plc.IsConnected && openTask.IsCompleted)
                    {
                        result.Value = ((ushort)await plc.ReadAsync(dbAddress)).ConvertToShort();
                        result.Connection = "Connection OK";
                    }
                    else
                    {
                        string PLCerror = result.Connection = "Problem with connection => check NETWORK or PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Connection = ex.Message;
            }
            return result;
        }
    }
}