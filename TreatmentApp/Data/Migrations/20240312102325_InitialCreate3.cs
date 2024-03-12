using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TreatmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ApiKeyRequired",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "ApiKeyRequired",
                table: "TimeIntervals");

            migrationBuilder.DropColumn(
                name: "ApiKeyRequired",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers");

            migrationBuilder.AddColumn<bool>(
                name: "ApiKeyRequired",
                table: "Treatments",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ApiKeyRequired",
                table: "TimeIntervals",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "TreatmentId",
                table: "Customers",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<bool>(
                name: "ApiKeyRequired",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Treatments_TreatmentId",
                table: "Customers",
                column: "TreatmentId",
                principalTable: "Treatments",
                principalColumn: "TreatmentId");
        }
    }
}
