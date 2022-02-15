using Microsoft.EntityFrameworkCore.Migrations;

namespace WaterProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProjectName = table.Column<string>(nullable: true),
                    ProjectType = table.Column<string>(nullable: true),
                    ProjectRegionalProgram = table.Column<string>(nullable: true),
                    ProjectImpact = table.Column<int>(nullable: false),
                    ProjectPhase = table.Column<string>(nullable: true),
                    ProjectFunctionalityStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 1, "Functional", 842, "Saint Paul's Roman Catholic Primary School", "In Service - Feb 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 23, "Community Managed", 500, "Kikoko Community Well", "Initial Installation: Apr 2012", "Wells for Masindi / Jinga Uganda", "Dug Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 22, "Under Community Care", 250, "Soussoubro Community", "Initial Installation: Aug 2014", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 21, "Under Community Care", 300, "Vouregane Community", "Initial Installation: Jan 2014", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 20, "Community Managed", 500, "Musenyi Community Well", "Initial Installation: Nov 2011", "Wells for Rwanda", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 19, "Low / No Water or Mechanical Breakdown", 155, "St.Stephen Eshihaka Secondary School", "In Service -Jan 2017", "Western Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 18, "Community Managed", 300, "Kakiriing Community Well", "Initial Installation: Mar 2011", "Wells for Kenya", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 17, "Community Managed", 500, "House of Hope Orphanage Well", "Initial Installation: Aug 2011", "Deep Wells -Kenya", "Borehole Well and Submersible Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 16, "Functional", 500, "Teresia Primary School Water Project", "In Service - Oct 2012", "Wells for Kenya", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 15, "Community Managed", 500, "Nyeaba Community", "Initial Installation: Aug 2013", "Wells for South Sudan -NeverThirst", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 14, "Functional", 314, "Kavyuni Salvation Army Primary School", "In Service -May 2020", "Southeastern Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 24, "Water Flowing -Needs Attention", 315, "Chegulo Community, Werabunuka Spring", "In Service -Nov 2018", "Western Kenya WaSH Program", "Protected Spring" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 13, "", 0, "St.Catherine Lema Girls School", "Estimated Install Date: 05 / 28 / 2022", "Southeastern Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 11, "Functional", 5000, "Lema Community A Sand Dam", "In Service -Dec 2021", "Southeastern Kenya WaSH Program", "Sand Dam" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 10, "Functional", 664, "Lungi, Gbaneh Bana, Next to Mosque", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 9, "Functional", 450, "SLMC Primary School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 8, "Functional", 1100, "Kingsway Secondary School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 7, "Functional", 176, "Kaffu Bullom, Kasongha OIC Vocational School", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 6, "Functional", 600, "Kamasondo, Raka Village", "In Service -Jan 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 5, "Functional", 1317, "Muroni Primary School", "In Service -Jan 2022", "Western Kenya WaSH Program", "Rainwater Catchment" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 4, "Functional", 493, "Esokone Primary School", "In Service -Feb 2022", "Western Kenya WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 3, "Functional", 175, "Shikutse B Community, Musava Spring", "In Service -Feb 2022", "Western Kenya WaSH Program", "Protected Spring" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 2, "Functional", 150, "Lungi, Tintafor, St.Augustine Secondary School Gate", "In Service -Feb 2022", "Port Loko, Sierra Leone WaSH Program", "Borehole Well and Hand Pump" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 12, "Community Managed", 500, "Taureg Refugee Camp, Burkina Faso", "In Service - Jan 2015", "Wells for Burkina Faso", "Well Rehab" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "ProjectFunctionalityStatus", "ProjectImpact", "ProjectName", "ProjectPhase", "ProjectRegionalProgram", "ProjectType" },
                values: new object[] { 25, "Low / No Water or Mechanical Breakdown", 500, "Khabukoshe Primary School", "In Service -Apr 2019", "Western Kenya WaSH Program", "Rainwater Catchment" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
