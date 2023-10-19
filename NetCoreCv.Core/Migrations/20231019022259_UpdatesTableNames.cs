using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetCoreCv.Core.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumVitae_Address_CurrentAddressId",
                table: "CurriculumVitae");

            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumVitae_AspNetUsers_UserId",
                table: "CurriculumVitae");

            migrationBuilder.DropForeignKey(
                name: "FK_DateRange_WorkExperiences_WorkExperienceId",
                table: "DateRange");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Address_AddressId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Company_CompanyId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_CurriculumVitae_CurriculumVitaeId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Address_AddressId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CurriculumVitae_CurriculumVitaeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperienceResponsibilities_WorkExperiences_WorkExperienceId",
                table: "WorkExperienceResponsibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Address_AddressId",
                table: "WorkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Company_CompanyId",
                table: "WorkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CurriculumVitae_CurriculumVitaeId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkExperienceResponsibilities",
                table: "WorkExperienceResponsibilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DateRange",
                table: "DateRange");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurriculumVitae",
                table: "CurriculumVitae");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "WorkExperienceResponsibilities",
                newName: "Responsibilities");

            migrationBuilder.RenameTable(
                name: "DateRange",
                newName: "DateRanges");

            migrationBuilder.RenameTable(
                name: "CurriculumVitae",
                newName: "CurriculumVitaes");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_WorkExperienceResponsibilities_WorkExperienceId",
                table: "Responsibilities",
                newName: "IX_Responsibilities_WorkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_DateRange_WorkExperienceId",
                table: "DateRanges",
                newName: "IX_DateRanges_WorkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumVitae_UserId",
                table: "CurriculumVitaes",
                newName: "IX_CurriculumVitaes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumVitae_CurrentAddressId",
                table: "CurriculumVitaes",
                newName: "IX_CurriculumVitaes_CurrentAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responsibilities",
                table: "Responsibilities",
                column: "ResponsibilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateRanges",
                table: "DateRanges",
                column: "DateRangeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurriculumVitaes",
                table: "CurriculumVitaes",
                column: "CurriculumVitaeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumVitaes_Addresses_CurrentAddressId",
                table: "CurriculumVitaes",
                column: "CurrentAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumVitaes_AspNetUsers_UserId",
                table: "CurriculumVitaes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateRanges_WorkExperiences_WorkExperienceId",
                table: "DateRanges",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Addresses_AddressId",
                table: "Education",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Companies_CompanyId",
                table: "Education",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_CurriculumVitaes_CurriculumVitaeId",
                table: "Education",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitaes",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Addresses_AddressId",
                table: "Projects",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CurriculumVitaes_CurriculumVitaeId",
                table: "Projects",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitaes",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responsibilities_WorkExperiences_WorkExperienceId",
                table: "Responsibilities",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Addresses_AddressId",
                table: "WorkExperiences",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Companies_CompanyId",
                table: "WorkExperiences",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CurriculumVitaes_CurriculumVitaeId",
                table: "WorkExperiences",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitaes",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumVitaes_Addresses_CurrentAddressId",
                table: "CurriculumVitaes");

            migrationBuilder.DropForeignKey(
                name: "FK_CurriculumVitaes_AspNetUsers_UserId",
                table: "CurriculumVitaes");

            migrationBuilder.DropForeignKey(
                name: "FK_DateRanges_WorkExperiences_WorkExperienceId",
                table: "DateRanges");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Addresses_AddressId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_Companies_CompanyId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Education_CurriculumVitaes_CurriculumVitaeId",
                table: "Education");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Addresses_AddressId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CurriculumVitaes_CurriculumVitaeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Responsibilities_WorkExperiences_WorkExperienceId",
                table: "Responsibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Addresses_AddressId",
                table: "WorkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_Companies_CompanyId",
                table: "WorkExperiences");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CurriculumVitaes_CurriculumVitaeId",
                table: "WorkExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responsibilities",
                table: "Responsibilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DateRanges",
                table: "DateRanges");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CurriculumVitaes",
                table: "CurriculumVitaes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Responsibilities",
                newName: "WorkExperienceResponsibilities");

            migrationBuilder.RenameTable(
                name: "DateRanges",
                newName: "DateRange");

            migrationBuilder.RenameTable(
                name: "CurriculumVitaes",
                newName: "CurriculumVitae");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Responsibilities_WorkExperienceId",
                table: "WorkExperienceResponsibilities",
                newName: "IX_WorkExperienceResponsibilities_WorkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_DateRanges_WorkExperienceId",
                table: "DateRange",
                newName: "IX_DateRange_WorkExperienceId");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumVitaes_UserId",
                table: "CurriculumVitae",
                newName: "IX_CurriculumVitae_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CurriculumVitaes_CurrentAddressId",
                table: "CurriculumVitae",
                newName: "IX_CurriculumVitae_CurrentAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkExperienceResponsibilities",
                table: "WorkExperienceResponsibilities",
                column: "ResponsibilityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DateRange",
                table: "DateRange",
                column: "DateRangeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CurriculumVitae",
                table: "CurriculumVitae",
                column: "CurriculumVitaeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumVitae_Address_CurrentAddressId",
                table: "CurriculumVitae",
                column: "CurrentAddressId",
                principalTable: "Address",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CurriculumVitae_AspNetUsers_UserId",
                table: "CurriculumVitae",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DateRange_WorkExperiences_WorkExperienceId",
                table: "DateRange",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Address_AddressId",
                table: "Education",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_Company_CompanyId",
                table: "Education",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Education_CurriculumVitae_CurriculumVitaeId",
                table: "Education",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitae",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Address_AddressId",
                table: "Projects",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CurriculumVitae_CurriculumVitaeId",
                table: "Projects",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitae",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperienceResponsibilities_WorkExperiences_WorkExperienceId",
                table: "WorkExperienceResponsibilities",
                column: "WorkExperienceId",
                principalTable: "WorkExperiences",
                principalColumn: "WorkExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Address_AddressId",
                table: "WorkExperiences",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_Company_CompanyId",
                table: "WorkExperiences",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CurriculumVitae_CurriculumVitaeId",
                table: "WorkExperiences",
                column: "CurriculumVitaeId",
                principalTable: "CurriculumVitae",
                principalColumn: "CurriculumVitaeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
