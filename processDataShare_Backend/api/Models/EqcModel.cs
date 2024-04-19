using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class EqcModel
    {
        public int Id { get; set; }
        public string? connection { get; set; }
        public short actualDowntime { get; set; }
        public string? ActualToolName { get; set; }
        //Basic Info
        public bool MachineAuto { get; set; }
        public bool ConveyorOK { get; set; }
        public int MainStepNumber { get; set; }
        public float CycleTime { get; set; }
        public int ProductionCurrentNum { get; set; }
        //Tool
        public bool ToolHome { get; set; }
        public bool HeaterOk { get; set; }
        public ushort ToolNumber { get; set; }
        //Gluestation
        public bool BluemeltOk { get; set; }
        public float ActualPressure { get; set; }
        public float SetAirInside1 { get; set; }
        public float SetAirOutside1 { get; set; }
        public float SetpumpSpeed1 { get; set; }
        public float SetAirInside2 { get; set; }
        public float SetAirOutside2 { get; set; }
        public float SetpumpSpeed2 { get; set; }
        public float SetAirInside3 { get; set; }
        public float SetpumpSpeed3 { get; set; }
        public float Actual_AirInside1 { get; set; }
        public float Actual_AirOutside1 { get; set; }
        public float Actual_AirInside2 { get; set; }
        public float Actual_AirOutside2 { get; set; }
        public float Actual_AirInside3 { get; set; }
        //Robot
        public bool RobotAutomaticMode { get; set; }
        public bool RobotRunning { get; set; }
        public bool RobotHome { get; set; }
        public bool RobotConnectedGripper { get; set; }
        public int RobotToolNumber { get; set; }
    }
}