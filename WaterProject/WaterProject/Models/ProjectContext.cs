using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Project>().HasData(

                new Project
                { ProjectId = 1, ProjectName = "Saint Paul's Roman Catholic Primary School" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 842, ProjectPhase = "In Service - Feb 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 2, ProjectName = "Lungi, Tintafor, St.Augustine Secondary School Gate" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 150, ProjectPhase = "In Service -Feb 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 3, ProjectName = "Shikutse B Community, Musava Spring" , ProjectType = "Protected Spring" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 175, ProjectPhase = "In Service -Feb 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 4, ProjectName = "Esokone Primary School" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 493, ProjectPhase = "In Service -Feb 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 5, ProjectName = "Muroni Primary School" , ProjectType = "Rainwater Catchment" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 1317, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 6, ProjectName = "Kamasondo, Raka Village" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 600, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 7, ProjectName = "Kaffu Bullom, Kasongha OIC Vocational School" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 176, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 8, ProjectName = "Kingsway Secondary School" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 1100, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 9, ProjectName = "SLMC Primary School" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 450, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 10, ProjectName = "Lungi, Gbaneh Bana, Next to Mosque" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program" , ProjectImpact = 664, ProjectPhase = "In Service -Jan 2022" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 11, ProjectName = "Lema Community A Sand Dam" , ProjectType = "Sand Dam" , ProjectRegionalProgram = "Southeastern Kenya WaSH Program" , ProjectImpact = 5000, ProjectPhase = "In Service -Dec 2021" , ProjectFunctionalityStatus = "Functional"},

                new Project
                { ProjectId = 12, ProjectName = "Taureg Refugee Camp, Burkina Faso" , ProjectType = "Well Rehab" , ProjectRegionalProgram = "Wells for Burkina Faso" , ProjectImpact = 500, ProjectPhase = "In Service - Jan 2015", ProjectFunctionalityStatus = "Community Managed"},

                new Project
                { ProjectId = 13, ProjectName = "St.Catherine Lema Girls School" , ProjectType = "Rainwater Catchment" , ProjectRegionalProgram = "Southeastern Kenya WaSH Program" , ProjectImpact = 0, ProjectPhase = "Estimated Install Date: 05 / 28 / 2022" , ProjectFunctionalityStatus = ""},
        
                new Project
                { ProjectId = 14, ProjectName = "Kavyuni Salvation Army Primary School" , ProjectType = "Rainwater Catchment" , ProjectRegionalProgram = "Southeastern Kenya WaSH Program" , ProjectImpact = 314, ProjectPhase = "In Service -May 2020" , ProjectFunctionalityStatus = "Functional"},
                new Project
                { ProjectId = 15, ProjectName = "Nyeaba Community" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Wells for South Sudan -NeverThirst", ProjectImpact = 500, ProjectPhase = "Initial Installation: Aug 2013", ProjectFunctionalityStatus = "Community Managed"},
                new Project
                { ProjectId = 16, ProjectName = "Teresia Primary School Water Project" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Wells for Kenya", ProjectImpact = 500, ProjectPhase = "In Service - Oct 2012", ProjectFunctionalityStatus = "Functional"},
                new Project
                { ProjectId = 17, ProjectName = "House of Hope Orphanage Well" , ProjectType = "Borehole Well and Submersible Pump" , ProjectRegionalProgram = "Deep Wells -Kenya" , ProjectImpact = 500, ProjectPhase = "Initial Installation: Aug 2011" , ProjectFunctionalityStatus = "Community Managed"},
                new Project
                { ProjectId = 18, ProjectName = "Kakiriing Community Well" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Wells for Kenya", ProjectImpact = 300, ProjectPhase = "Initial Installation: Mar 2011", ProjectFunctionalityStatus = "Community Managed"},
                new Project
                { ProjectId = 19, ProjectName = "St.Stephen Eshihaka Secondary School" , ProjectType = "Rainwater Catchment" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 155, ProjectPhase = "In Service -Jan 2017" , ProjectFunctionalityStatus = "Low / No Water or Mechanical Breakdown"},
                new Project
                { ProjectId = 20, ProjectName = "Musenyi Community Well" , ProjectType = "Borehole Well and Hand Pump" , ProjectRegionalProgram = "Wells for Rwanda", ProjectImpact = 500, ProjectPhase = "Initial Installation: Nov 2011", ProjectFunctionalityStatus = "Community Managed"},
                new Project
                { ProjectId = 21, ProjectName = "Vouregane Community" , ProjectType = "Well Rehab" , ProjectRegionalProgram = "Wells for Burkina Faso" , ProjectImpact = 300, ProjectPhase = "Initial Installation: Jan 2014", ProjectFunctionalityStatus = "Under Community Care"},
                new Project
                { ProjectId = 22, ProjectName = "Soussoubro Community" , ProjectType = "Well Rehab" , ProjectRegionalProgram = "Wells for Burkina Faso" , ProjectImpact = 250, ProjectPhase = "Initial Installation: Aug 2014", ProjectFunctionalityStatus = "Under Community Care"},
                new Project
                { ProjectId = 23, ProjectName = "Kikoko Community Well" , ProjectType = "Dug Well and Hand Pump" , ProjectRegionalProgram = "Wells for Masindi / Jinga Uganda", ProjectImpact = 500, ProjectPhase = "Initial Installation: Apr 2012", ProjectFunctionalityStatus = "Community Managed"},
                new Project
                { ProjectId = 24, ProjectName = "Chegulo Community, Werabunuka Spring" , ProjectType = "Protected Spring" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 315, ProjectPhase = "In Service -Nov 2018" , ProjectFunctionalityStatus = "Water Flowing -Needs Attention"},
                new Project
                { ProjectId = 25, ProjectName = "Khabukoshe Primary School" , ProjectType = "Rainwater Catchment" , ProjectRegionalProgram = "Western Kenya WaSH Program" , ProjectImpact = 500, ProjectPhase = "In Service -Apr 2019" , ProjectFunctionalityStatus = "Low / No Water or Mechanical Breakdown"}
            );
        }
    }
}
