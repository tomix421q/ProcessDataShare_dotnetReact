using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class asqUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq6",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq6",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq6",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq6",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq5",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq5",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq5",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq5",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq4",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq4",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq4",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq4",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq3",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq3",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq3",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq3",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "Product_A",
                table: "AsqDatas_asq2",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_B",
                table: "AsqDatas_asq2",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq2",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq2",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq2",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq3");

            migrationBuilder.DropColumn(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq3");

            migrationBuilder.DropColumn(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq3");

            migrationBuilder.DropColumn(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq3");

            migrationBuilder.DropColumn(
                name: "Product_A",
                table: "AsqDatas_asq2");

            migrationBuilder.DropColumn(
                name: "Product_B",
                table: "AsqDatas_asq2");

            migrationBuilder.DropColumn(
                name: "ROB1_ActStep",
                table: "AsqDatas_asq2");

            migrationBuilder.DropColumn(
                name: "ROB1_CycleTime",
                table: "AsqDatas_asq2");

            migrationBuilder.DropColumn(
                name: "ROB2_ActStep",
                table: "AsqDatas_asq2");

            migrationBuilder.DropColumn(
                name: "ROB2_CycleTime",
                table: "AsqDatas_asq2");
        }
    }
}
