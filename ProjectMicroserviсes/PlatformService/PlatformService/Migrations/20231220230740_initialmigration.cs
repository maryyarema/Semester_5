using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformService.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Platforms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalProcedure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeviceUsed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StandardsCompliance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnicalRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Platforms");
        }
    }
}
