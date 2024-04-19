using api.Interfaces.Live;
using api.Models;
using S7.Net;

namespace api.Repository
{
    public class EqcLiveDataRepo : IEqcLiveDataService
    {
        private string _ipAddress;

        // 
        // READ DATA
        // 
        public async Task<EqcModel> GetEqcLiveData()
        {
            var eqcModel = new EqcModel();

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        eqcModel.connection = "Connection OK";

                        eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                        eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                        int startAdress = 258; // Adresa UDT
                        int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                        int numberDB = 189; // Cislo DB blocku v plc

                        //Scan multiply
                        var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                        //basic info
                        eqcModel.MachineAuto = udtData[0].SelectBit(0);
                        eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                        eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                        eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                        eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                        //tool
                        eqcModel.ToolHome = udtData[12].SelectBit(0);
                        eqcModel.HeaterOk = udtData[12].SelectBit(1);
                        eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                        //bluemelt gluestation
                        eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                        eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                        eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                        eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                        eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                        eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                        eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                        eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                        eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                        eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                        eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                        eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                        eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                        eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                        eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                        //Robot
                        eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                        eqcModel.RobotRunning = udtData[74].SelectBit(1);
                        eqcModel.RobotHome = udtData[74].SelectBit(2);
                        eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                        eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());
                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error: {ex.Message}";
            }

            return eqcModel;
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
                    await plc.OpenAsync();
                    if (plc.IsConnected)
                    {
                        return (true, "Connection OK");
                    }
                    else
                    {
                        return (false, "Problem with connection => check NETWORK or PLC");
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



