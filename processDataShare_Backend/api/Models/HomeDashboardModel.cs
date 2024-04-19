namespace api.Models
{
    public class HomeDashboardModel
    {
        //_______________ASQ_MODELS________________
        public int ASQ_1_ROB1_Downtime_Time { get; set; }
        public int ASQ_1_ROB2_Downtime_Time { get; set; }
        public int ASQ_2_ROB1_Downtime_Time { get; set; }
        public int ASQ_2_ROB2_Downtime_Time { get; set; }
        public int ASQ_3_ROB1_Downtime_Time { get; set; }
        public int ASQ_3_ROB2_Downtime_Time { get; set; }
        public int ASQ_4_ROB1_Downtime_Time { get; set; }
        public int ASQ_4_ROB2_Downtime_Time { get; set; }
        public int ASQ_5_ROB1_Downtime_Time { get; set; }
        public int ASQ_5_ROB2_Downtime_Time { get; set; }
        public int ASQ_6_ROB1_Downtime_Time { get; set; }
        public int ASQ_6_ROB2_Downtime_Time { get; set; }
        //connections 
        public string connectionAsq1 { get; set; }
        public string connectionAsq2 { get; set; }
        public string connectionAsq3 { get; set; }
        public string connectionAsq4 { get; set; }
        public string connectionAsq5 { get; set; }
        public string connectionAsq6 { get; set; }

        //_____________Opel_Armrest______________
        public int OpelArmrestFD_actualDowntime { get; set; }
        public int OpelArmrestRD_actualDowntime { get; set; }
        public int OpelInsertFD_actualDowntime { get; set; }
        public int OpelInsertRD_actualDowntime { get; set; }


        //connections
        public string connectionOpelArmrestFd { get; set; }
        public string connectionOpelArmrestRd { get; set; }
        public string connectionOpelInsertFd { get; set; }
        public string connectionOpelInsertRd { get; set; }


        //__________________EqcMf______________________
        public int EqcMF1_actualDownTime { get; set; }
        public int EqcMF2_actualDownTime { get; set; }
        public int EqcMF3_actualDownTime { get; set; }
        public int EqcMF4_actualDownTime { get; set; }
        public int EqcMF5_actualDownTime { get; set; }
        public int EqcMF6_actualDownTime { get; set; }
        public int EqcMF7_actualDownTime { get; set; }
        public int EqcMF8_actualDownTime { get; set; }
        //connections
        public string connectionEqcMF1 { get; set; }
        public string connectionEqcMF2 { get; set; }
        public string connectionEqcMF3 { get; set; }
        public string connectionEqcMF4 { get; set; }
        public string connectionEqcMF5 { get; set; }
        public string connectionEqcMF6 { get; set; }
        public string connectionEqcMF7 { get; set; }
        public string connectionEqcMF8 { get; set; }

        //BMW
        public int G26Bmw { get; set; }
        public string connectionG26 { get; set; }
    }
}