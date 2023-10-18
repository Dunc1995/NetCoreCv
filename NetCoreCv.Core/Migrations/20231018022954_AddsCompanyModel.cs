using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreCv.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddsCompanyModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "WorkExperiences",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Education",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperiences_CompanyId",
                table: "WorkExperiences",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Education_CompanyId",
                table: "Education",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Company_CompanyId",
                table: "Education",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Company_CompanyId",
                table: "WorkExperiences",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Education_Company_CompanyId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Company_CompanyId",
                table: "WorkExperiences");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropIndex(
                name: "IX_WorkExperiences_CompanyId",
                table: "WorkExperiences");

            migrationBuilder.DropIndex(
                name: "IX_Education_CompanyId",
                table: "Education");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Education");
        }
    }
}
