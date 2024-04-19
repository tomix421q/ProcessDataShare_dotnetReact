namespace api.Models
{
    public class OpelArmrestModel
    {
        public string connection { get; set; }
        //Classic
        public short actualDowntime { get; set; }
        public int rightPart { get; set; }
        public int leftPart { get; set; }
        public int actualStep { get; set; }
        //UDT
        public float tempLeftUp { get; set; }
        public float tempRightUp { get; set; }
        public float tempRightDown { get; set; }
        public float tempLeftDown { get; set; }
        public int heatingTime { get; set; }
        public int heatingSetPointMax { get; set; }
        public int foldingTime { get; set; }
        public int foldingSetPointMax { get; set; }
        public int cycleTime { get; set; }
        public DateTime shotDateTime { get; set; }
        public ushort mouldNumber { get; set; }
        public int recipe { get; set; }
        public bool pyroIndicatorOnOff { get; set; }
    }
}