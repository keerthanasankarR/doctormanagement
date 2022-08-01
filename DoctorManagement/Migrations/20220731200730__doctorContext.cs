using Microsoft.EntityFrameworkCore.Migrations;

namespace DoctorManagement.Migrations
{
    public partial class _doctorContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_doctorContext",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientName = table.Column<string>(type: "varchar(200)", nullable: true),
                    PatientApppointmentDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<string>(type: "varchar(200)", nullable: true),
                    BloodGroup = table.Column<string>(type: "varchar(200)", nullable: true),
                    EmailID = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phonenumber = table.Column<string>(type: "varchar(200)", nullable: true),
                    DoctorType = table.Column<string>(type: "varchar(200)", nullable: true),
                    Description = table.Column<string>(type: "varchar(200)", nullable: true),
                    Technician = table.Column<string>(type: "varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__doctorContext", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_doctorContext");
        }
    }
}
