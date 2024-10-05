using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMvc.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CanCuoc",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CongTy",
                table: "Person",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "TEXT",
                maxLength: 8,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanCuoc",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "CongTy",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");
        }
    }
}
