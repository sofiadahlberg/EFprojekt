using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreatmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "Customers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "TreatmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "TreatmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
