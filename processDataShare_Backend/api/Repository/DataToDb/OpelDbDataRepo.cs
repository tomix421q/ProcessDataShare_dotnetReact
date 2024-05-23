using api.DbData;
using api.Interfaces.CollectToDb;
using api.Models.databaseModels.OPEL;
using S7.Net;


namespace api.Repository.DataToDb
{
    public class OpelDbDataRepo : IOpelDataDb
    {
        //DB
        private readonly ApplicationDBContext _context;

        public OpelDbDataRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        //IP ADRESS
        private string _ipAddress_armrestFr;
        private string _ipAddress_armrestRr;
        // private string _ipAddress_insertFr;
        // private string _ipAddress_insertRr;

        //DATA
        public async Task<Db_ArmrestFr> GetLiveDataToDb_opelArmrest_Fr()
        {
            var armrestFr = new Db_ArmrestFr();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_armrestFr, 0, 1))
                {
                    plc.Open();
                    //time
                    DateTime currentDate = DateTime.Now;
                    armrestFr.TimeStamp = currentDate;
                    //
                    int startAdress = 54; // Adresa UDT
                    int sizeInBytes = 8; // Veľkosť UDT v bajtoch 39
                    int numberDB = 26; // Cislo DB blocku v plc
                    //Scan UDT
                    var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);

                    armrestFr.WaterTempLeft = (double)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(0).Take(4).ToArray()), 1);
                    armrestFr.WaterTempRight = (double)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(4).Take(4).ToArray()), 1);
                    armrestFr.Message = "OK";
                }
            }
            catch (Exception ex)
            {
                armrestFr.Message = $"Error: {ex.Message}";
            }
            return armrestFr;
        }

        public async Task<Db_ArmrestRr> GetLiveDataToDb_opelArmrest_Rr()
        {
            var armrestRr = new Db_ArmrestRr();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_armrestRr, 0, 1))
                {
                    plc.Open();
                    //time
                    DateTime currentDate = DateTime.Now;
                    armrestRr.TimeStamp = currentDate;
                    //
                    int startAdress = 54; // Adresa UDT
                    int sizeInBytes = 8; // Veľkosť UDT v bajtoch 39
                    int numberDB = 26; // Cislo DB blocku v plc
                    //Scan UDT
                    var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);

                    armrestRr.WaterTempLeft = (double)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(0).Take(4).ToArray()), 2);
                    armrestRr.WaterTempRight = (double)Math.Round(S7.Net.Types.Real.FromByteArray(udtData.Skip(4).Take(4).ToArray()), 2);
                    armrestRr.Message = "OK";
                }

            }
            catch (Exception ex)
            {
                armrestRr.Message = $"Error: {ex.Message}";
            }
            return armrestRr;
        }

        // 
        //IP ADRESS
        // 
        public async Task<(bool success, string errorMessage)> SetIpAddress_opelArmrest_Fr(string ipAddress)
        {
            _ipAddress_armrestFr = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_armrestFr, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection OPEL_Armrest FR -> OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect OPEL_Armrest FR to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error OPEL_Armrest FR: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_opelArmrest_Rr(string ipAddress)
        {
            _ipAddress_armrestRr = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_armrestRr, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection OPEL_Armrest RR -> OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect OPEL_Armrest RR to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error OPEL_Armrest RR: {ex.Message}");
            }
        }


    }
}