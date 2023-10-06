using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreCv.Core.Migrations
{
    /// <inheritdoc />
    public partial class SimplifiesNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkExperienceResponsibilityId",
                table: "WorkExperienceResponsibilities",
                newName: "ResponsibilityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResponsibilityId",
                table: "WorkExperienceResponsibilities",
                newName: "WorkExperienceResponsibilityId");
        }
    }
}
