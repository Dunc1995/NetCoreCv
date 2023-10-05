using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreCv.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddsResponsibilities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkExperienceResponsibilities",
                columns: table => new
                {
                    WorkExperienceResponsibilityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    WorkExperienceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkExperienceResponsibilities", x => x.WorkExperienceResponsibilityId);
                    table.ForeignKey(
                        name: "FK_WorkExperienceResponsibilities_WorkExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "WorkExperiences",
                        principalColumn: "WorkExperienceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkExperienceResponsibilities_WorkExperienceId",
                table: "WorkExperienceResponsibilities",
                column: "WorkExperienceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkExperienceResponsibilities");
        }
    }
}
