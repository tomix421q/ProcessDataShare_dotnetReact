using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class asqs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Product_A",
                table: "AsqDatas_asq6",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_B",
                table: "AsqDatas_asq6",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_A",
                table: "AsqDatas_asq5",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_B",
                table: "AsqDatas_asq5",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_A",
                table: "AsqDatas_asq4",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_B",
                table: "AsqDatas_asq4",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_A",
                table: "AsqDatas_asq3",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Product_B",
                table: "AsqDatas_asq3",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_A",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "Product_B",
                table: "AsqDatas_asq6");

            migrationBuilder.DropColumn(
                name: "Product_A",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "Product_B",
                table: "AsqDatas_asq5");

            migrationBuilder.DropColumn(
                name: "Product_A",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "Product_B",
                table: "AsqDatas_asq4");

            migrationBuilder.DropColumn(
                name: "Product_A",
                table: "AsqDatas_asq3");

            migrationBuilder.DropColumn(
                name: "Product_B",
                table: "AsqDatas_asq3");
        }
    }
}
