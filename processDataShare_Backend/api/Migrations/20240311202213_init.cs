using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AsqDatas_asq2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas_asq2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsqDatas_asq3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas_asq3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsqDatas_asq4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas_asq4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsqDatas_asq5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas_asq5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsqDatas_asq6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ROB1_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB1_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB1_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB1_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB1_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    ROB2_Downtime_Time = table.Column<int>(type: "int", nullable: false),
                    ROB2_FormNumber = table.Column<int>(type: "int", nullable: false),
                    ROB2_WeightActualValue = table.Column<float>(type: "real", nullable: false),
                    ROB2_Temperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_SetTemperature = table.Column<float>(type: "real", nullable: false),
                    ROB2_TimeDrying = table.Column<float>(type: "real", nullable: false),
                    Global_RefValue = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolMinus = table.Column<float>(type: "real", nullable: false),
                    Global_WeightTolPlus = table.Column<float>(type: "real", nullable: false),
                    Global_GoWeightAfter = table.Column<int>(type: "int", nullable: false),
                    Global_MixingTime = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsqDatas_asq6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc3",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc4",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc4", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc5",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc5", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc6",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc6", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc7",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc7", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EqcDatas_eqc8",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualToolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainStepNumber = table.Column<int>(type: "int", nullable: false),
                    CycleTime = table.Column<float>(type: "real", nullable: false),
                    ProductionCurrentNum = table.Column<int>(type: "int", nullable: false),
                    HeaterOk = table.Column<bool>(type: "bit", nullable: false),
                    ToolNumber = table.Column<int>(type: "int", nullable: false),
                    BluemeltOk = table.Column<bool>(type: "bit", nullable: false),
                    ActualPressure = table.Column<float>(type: "real", nullable: false),
                    SetAirInside1 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside1 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed1 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside2 = table.Column<float>(type: "real", nullable: false),
                    SetAirOutside2 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed2 = table.Column<float>(type: "real", nullable: false),
                    SetAirInside3 = table.Column<float>(type: "real", nullable: false),
                    SetpumpSpeed3 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside1 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirOutside2 = table.Column<float>(type: "real", nullable: false),
                    Actual_AirInside3 = table.Column<float>(type: "real", nullable: false),
                    RobotConnectedGripper = table.Column<bool>(type: "bit", nullable: false),
                    RobotToolNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EqcDatas_eqc8", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsqDatas_asq2");

            migrationBuilder.DropTable(
                name: "AsqDatas_asq3");

            migrationBuilder.DropTable(
                name: "AsqDatas_asq4");

            migrationBuilder.DropTable(
                name: "AsqDatas_asq5");

            migrationBuilder.DropTable(
                name: "AsqDatas_asq6");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc1");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc2");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc3");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc4");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc5");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc6");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc7");

            migrationBuilder.DropTable(
                name: "EqcDatas_eqc8");
        }
    }
}
