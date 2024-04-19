using api.Interfaces.Live;
using api.Models;
using S7.Net;

namespace api.Repository
{
    public class OpelLiveDataRepo : IOpelLiveDataService
    {
        // 
        // READ DATA ARMREST
        // 
        private string _ipAddress;
        public async Task<OpelArmrestModel> GetOpelArmrestLiveData()
        {
            var OpelArmrestmodel = new OpelArmrestModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        OpelArmrestmodel.connection = "Connection OK";

                        OpelArmrestmodel.rightPart = ((uint)await plc.ReadAsync("DB26.DBD2.0")).ConvertToInt();
                        OpelArmrestmodel.leftPart = ((uint)await plc.ReadAsync("DB26.DBD6.0")).ConvertToInt();
                        OpelArmrestmodel.actualStep = ((uint)await plc.ReadAsync("DB26.DBD10.0")).ConvertToInt();
                        OpelArmrestmodel.actualDowntime = ((ushort)await plc.ReadAsync("DB26.DBW0.0")).ConvertToShort();

                        int startAdress = 14; // Adresa UDT
                        int sizeInBytes = 39; // Veľkosť UDT v bajtoch 39
                        int numberDB = 26; // Cislo DB blocku v plc

                        //Scan UDT
                        var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                        // UDT
                        OpelArmrestmodel.tempLeftUp = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(0).Take(4).ToArray()));
                        OpelArmrestmodel.tempRightUp = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(4).Take(4).ToArray()));
                        OpelArmrestmodel.tempLeftDown = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(8).Take(4).ToArray()));
                        OpelArmrestmodel.tempRightDown = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(12).Take(4).ToArray()));
                        OpelArmrestmodel.heatingTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(16).Take(2).ToArray()) / 10;
                        OpelArmrestmodel.heatingSetPointMax = S7.Net.Types.Int.FromByteArray(udtData.Skip(18).Take(2).ToArray()) / 10;
                        OpelArmrestmodel.foldingTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(20).Take(2).ToArray()) / 10;
                        OpelArmrestmodel.foldingSetPointMax = S7.Net.Types.Int.FromByteArray(udtData.Skip(22).Take(2).ToArray()) / 10;
                        OpelArmrestmodel.cycleTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(24).Take(2).ToArray()) / 10;
                        OpelArmrestmodel.shotDateTime = S7.Net.Types.DateTime.FromByteArray(udtData.Skip(26).Take(8).ToArray());
                        OpelArmrestmodel.mouldNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(34).Take(2).ToArray());
                        OpelArmrestmodel.recipe = S7.Net.Types.Int.FromByteArray(udtData.Skip(36).Take(2).ToArray());
                        OpelArmrestmodel.pyroIndicatorOnOff = udtData[38].SelectBit(0);
                    }
                    else
                    {
                        OpelArmrestmodel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                OpelArmrestmodel.connection = ex.Message;
            }
            return OpelArmrestmodel;
        }

        // 
        // READ DATA INSERT
        // 
        public async Task<OpelInsertModel> GetOpelInsertLiveData()
        {
            var OpelInsertmodel = new OpelInsertModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        OpelInsertmodel.connection = "Connection OK";

                        OpelInsertmodel.rightPart = ((uint)await plc.ReadAsync("DB26.DBD2.0")).ConvertToInt();
                        OpelInsertmodel.leftPart = ((uint)await plc.ReadAsync("DB26.DBD6.0")).ConvertToInt();
                        OpelInsertmodel.actualStep = ((uint)await plc.ReadAsync("DB26.DBD10.0")).ConvertToInt();
                        OpelInsertmodel.actualDowntime = ((ushort)await plc.ReadAsync("DB26.DBW0.0")).ConvertToShort();

                        int startAdress = 14; // Adresa UDT
                        int sizeInBytes = 41; // Veľkosť UDT v bajtoch 39
                        int numberDB = 26; // Cislo DB blocku v plc

                        //Scan UDT
                        var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                        // UDT
                        OpelInsertmodel.tempLeftUp = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(0).Take(4).ToArray()));
                        OpelInsertmodel.tempRightUp = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(4).Take(4).ToArray()));
                        OpelInsertmodel.tempLeftDown = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(8).Take(4).ToArray()));
                        OpelInsertmodel.tempRightDown = (int)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(12).Take(4).ToArray()));
                        OpelInsertmodel.heatingTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(16).Take(2).ToArray()) / 10;
                        OpelInsertmodel.heatingSetPointMax = S7.Net.Types.Int.FromByteArray(udtData.Skip(18).Take(2).ToArray()) / 10;
                        OpelInsertmodel.foldingTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(20).Take(2).ToArray()) / 10;
                        OpelInsertmodel.foldingSetPointMax = S7.Net.Types.Int.FromByteArray(udtData.Skip(22).Take(2).ToArray()) / 10;
                        OpelInsertmodel.cycleTime = S7.Net.Types.Int.FromByteArray(udtData.Skip(24).Take(2).ToArray()) / 10;
                        OpelInsertmodel.shotDateTime = S7.Net.Types.DateTime.FromByteArray(udtData.Skip(26).Take(8).ToArray());
                        OpelInsertmodel.mouldNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(34).Take(2).ToArray());
                        OpelInsertmodel.recipe = S7.Net.Types.Int.FromByteArray(udtData.Skip(36).Take(2).ToArray());
                        OpelInsertmodel.partRecipe = S7.Net.Types.Int.FromByteArray(udtData.Skip(38).Take(2).ToArray());
                        OpelInsertmodel.pyroIndicatorOnOff = udtData[40].SelectBit(0);
                        OpelInsertmodel.Workside_A = udtData[40].SelectBit(1);
                        OpelInsertmodel.Workside_B = udtData[40].SelectBit(2);
                    }

                }
            }
            catch (Exception ex)
            {
                OpelInsertmodel.connection = $"Error: {ex.Message}";
            }
            return OpelInsertmodel;
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