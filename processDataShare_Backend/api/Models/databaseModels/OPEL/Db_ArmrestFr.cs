
namespace api.Models.databaseModels.OPEL
{
      public class Db_ArmrestFr
      {
            public int Id { get; set; }
            public DateTime TimeStamp { get; set; }
            public string? Message { get; set; } = "PLC OK";
            //Classic
            // public int rightPart { get; set; }
            // public int leftPart { get; set; }
            //UDT
            // public float tempLeftUp { get; set; }
            // public float tempRightUp { get; set; }
            // public float tempRightDown { get; set; }
            // public float tempLeftDown { get; set; }
            // public int heatingTime { get; set; }
            // public int heatingSetPointMax { get; set; }
            // public int foldingTime { get; set; }
            // public int foldingSetPointMax { get; set; }
            // public int cycleTime { get; set; }
            // public ushort mouldNumber { get; set; }
            // public int recipe { get; set; }
            // public bool pyroIndicatorOnOff { get; set; }
            public double WaterTempLeft { get; set; }
            public double WaterTempRight { get; set; }
      }
}