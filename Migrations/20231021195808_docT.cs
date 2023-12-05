using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dashbord.Migrations
{
    /// <inheritdoc />
    public partial class docT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doctorId",
                table: "clinicTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DoctorTable",
                columns: table => new
                {
                    doctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    idNumber = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    phone = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    docSpecialization = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorTable", x => x.doctorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clinicTable_doctorId",
                table: "clinicTable",
                column: "doctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_clinicTable_DoctorTable_doctorId",
                table: "clinicTable",
                column: "doctorId",
                principalTable: "DoctorTable",
                principalColumn: "doctorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clinicTable_DoctorTable_doctorId",
                table: "clinicTable");

            migrationBuilder.DropTable(
                name: "DoctorTable");

            migrationBuilder.DropIndex(
                name: "IX_clinicTable_doctorId",
                table: "clinicTable");

            migrationBuilder.DropColumn(
                name: "doctorId",
                table: "clinicTable");
        }
    }
}
