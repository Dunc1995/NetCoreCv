using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreCv.Core.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesDateRangeSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "WorkExperiences");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "WorkExperiences");

            migrationBuilder.CreateTable(
                name: "DateRange",
                columns: table => new
                {
                    DateRangeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WorkExperienceId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateRange", x => x.DateRangeId);
                    table.ForeignKey(
                        name: "FK_DateRange_WorkExperiences_WorkExperienceId",
                        column: x => x.WorkExperienceId,
                        principalTable: "WorkExperiences",
                        principalColumn: "WorkExperienceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DateRange_WorkExperienceId",
                table: "DateRange",
                column: "WorkExperienceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateRange");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "WorkExperiences",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "WorkExperiences",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
