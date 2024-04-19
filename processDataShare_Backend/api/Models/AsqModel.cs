namespace api.Models
{
    public class AsqModel
    {
        public int Id { get; set; }
        //ROB1 
        public int ROB1_Downtime_Time { get; set; }
        public int ROB1_FormNumber { get; set; }
        public float ROB1_WeightActualValue { get; set; }
        public float ROB1_Temperature { get; set; }
        public float ROB1_SetTemperature { get; set; }
        public float ROB1_TimeDrying { get; set; }
        //ROB2
        public int ROB2_Downtime_Time { get; set; }
        public int ROB2_FormNumber { get; set; }
        public float ROB2_WeightActualValue { get; set; }
        public float ROB2_Temperature { get; set; }
        public float ROB2_SetTemperature { get; set; }
        public float ROB2_TimeDrying { get; set; }

        //Global
        public float Global_RefValue { get; set; }
        public float Global_WeightTolMinus { get; set; }
        public float Global_WeightTolPlus { get; set; }
        public int Global_GoWeightAfter { get; set; }
        public float Global_MixingTime { get; set; }
        public string connection { get; set; }
    }
}