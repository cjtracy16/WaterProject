using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zip = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    Anonymous = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    ProjectRegionalProgram = table.Column<string>(nullable: true),
                    ProjectImpact = table.Column<long>(nullable: false),
                    ProjectPhase = table.Column<string>(nullable: true),
                    ProjectFunctionalityStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "CartLineItem",
                columns: table => new
                {
                    LineID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectId = table.Column<long>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DonationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLineItem", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_CartLineItem_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "DonationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLineItem_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 1L, "Functional", 842L, "Saint Paul's Roman Catholic Primary School", "In Service - Feb 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 23L, "Community Managed", 500L, "Kikoko Community Well", "Initial Installation: Apr 2012", "Wells for Masindi / Jinga Uganda", "Dug Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 22L, "Under Community Care", 250L, "Soussoubro Community", "Initial Installation: Aug 2014", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 21L, "Under Community Care", 300L, "Vouregane Community", "Initial Installation: Jan 2014", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 20L, "Community Managed", 500L, "Musenyi Community Well", "Initial Installation: Nov 2011", "Wells for Rwanda", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 19L, "Low / No Water or Mechanical Breakdown", 155L, "St.Stephen Eshihaka Secondary School", "In Service -Jan 2017", "Western Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 18L, "Community Managed", 300L, "Kakiriing Community Well", "Initial Installation: Mar 2011", "Wells for Kenya", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 17L, "Community Managed", 500L, "House of Hope Orphanage Well", "Initial Installation: Aug 2011", "Deep Wells -Kenya", "Borehole Well and Submersible Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 16L, "Functional", 500L, "Teresia Primary School Water Project", "In Service - Oct 2012", "Wells for Kenya", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 15L, "Community Managed", 500L, "Nyeaba Community", "Initial Installation: Aug 2013", "Wells for South Sudan -NeverThirst", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 14L, "Functional", 314L, "Kavyuni Salvation Army Primary School", "In Service -May 2020", "Southeastern Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 24L, "Water Flowing -Needs Attention", 315L, "Chegulo Community, Werabunuka Spring", "In Service -Nov 2018", "Western Kenya WaSH Program", "Protected Spring" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 13L, "", 0L, "St.Catherine Lema Girls School", "Estimated Install Date: 05 / 28 / 2022", "Southeastern Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 11L, "Functional", 5000L, "Lema Community A Sand Dam", "In Service -Dec 2021", "Southeastern Kenya WaSH Program", "Sand Dam" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 10L, "Functional", 664L, "Lungi, Gbaneh Bana, Next to Mosque", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 9L, "Functional", 450L, "SLMC Primary School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 8L, "Functional", 1100L, "Kingsway Secondary School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 7L, "Functional", 176L, "Kaffu Bullom, Kasongha OIC Vocational School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 6L, "Functional", 600L, "Kamasondo, Raka Village", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 5L, "Functional", 1317L, "Muroni Primary School", "In Service -Jan 2022", "Western Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 4L, "Functional", 493L, "Esokone Primary School", "In Service -Feb 2022", "Western Kenya WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 3L, "Functional", 175L, "Shikutse B Community, Musava Spring", "In Service -Feb 2022", "Western Kenya WaSH Program", "Protected Spring" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 2L, "Functional", 150L, "Lungi, Tintafor, St.Augustine Secondary School Gate", "In Service -Feb 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 12L, "Community Managed", 500L, "Taureg Refugee Camp, Burkina Faso", "In Service - Jan 2015", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 25L, "Low / No Water or Mechanical Breakdown", 500L, "Khabukoshe Primary School", "In Service -Apr 2019", "Western Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItem_DonationId",
                table: "CartLineItem",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItem_ProjectId",
                table: "CartLineItem",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLineItem");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
