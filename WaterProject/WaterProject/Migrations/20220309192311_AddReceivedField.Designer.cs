﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterProject.Models;

namespace WaterProject.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20220309192311_AddReceivedField")]
    partial class AddReceivedField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("WaterProject.Models.CartLineItem", b =>
                {
                    b.Property<int>("LineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DonationId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineID");

                    b.HasIndex("DonationId");

                    b.HasIndex("ProjectId");

                    b.ToTable("CartLineItem");
                });

            modelBuilder.Entity("WaterProject.Models.Donation", b =>
                {
                    b.Property<int>("DonationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Anonymous")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DonationReceived")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("DonationId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("WaterProject.Models.Project", b =>
                {
                    b.Property<long>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectFunctionalityStatus")
                        .HasColumnType("TEXT");

                    b.Property<long>("ProjectImpact")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectPhase")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectRegionalProgram")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectType")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 842L,
                            ProjectName = "Saint Paul's Roman Catholic Primary School",
                            ProjectPhase = "In Service - Feb 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 2L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 150L,
                            ProjectName = "Lungi, Tintafor, St.Augustine Secondary School Gate",
                            ProjectPhase = "In Service -Feb 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 3L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 175L,
                            ProjectName = "Shikutse B Community, Musava Spring",
                            ProjectPhase = "In Service -Feb 2022",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Protected Spring"
                        },
                        new
                        {
                            ProjectId = 4L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 493L,
                            ProjectName = "Esokone Primary School",
                            ProjectPhase = "In Service -Feb 2022",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 5L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 1317L,
                            ProjectName = "Muroni Primary School",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Rainwater Catchment"
                        },
                        new
                        {
                            ProjectId = 6L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 600L,
                            ProjectName = "Kamasondo, Raka Village",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 7L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 176L,
                            ProjectName = "Kaffu Bullom, Kasongha OIC Vocational School",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 8L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 1100L,
                            ProjectName = "Kingsway Secondary School",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 9L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 450L,
                            ProjectName = "SLMC Primary School",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 10L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 664L,
                            ProjectName = "Lungi, Gbaneh Bana, Next to Mosque",
                            ProjectPhase = "In Service -Jan 2022",
                            ProjectRegionalProgram = "Port Loko, Sierra Leone WaSH Program",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 11L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 5000L,
                            ProjectName = "Lema Community A Sand Dam",
                            ProjectPhase = "In Service -Dec 2021",
                            ProjectRegionalProgram = "Southeastern Kenya WaSH Program",
                            ProjectType = "Sand Dam"
                        },
                        new
                        {
                            ProjectId = 12L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 500L,
                            ProjectName = "Taureg Refugee Camp, Burkina Faso",
                            ProjectPhase = "In Service - Jan 2015",
                            ProjectRegionalProgram = "Wells for Burkina Faso",
                            ProjectType = "Well Rehab"
                        },
                        new
                        {
                            ProjectId = 13L,
                            ProjectFunctionalityStatus = "",
                            ProjectImpact = 0L,
                            ProjectName = "St.Catherine Lema Girls School",
                            ProjectPhase = "Estimated Install Date: 05 / 28 / 2022",
                            ProjectRegionalProgram = "Southeastern Kenya WaSH Program",
                            ProjectType = "Rainwater Catchment"
                        },
                        new
                        {
                            ProjectId = 14L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 314L,
                            ProjectName = "Kavyuni Salvation Army Primary School",
                            ProjectPhase = "In Service -May 2020",
                            ProjectRegionalProgram = "Southeastern Kenya WaSH Program",
                            ProjectType = "Rainwater Catchment"
                        },
                        new
                        {
                            ProjectId = 15L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 500L,
                            ProjectName = "Nyeaba Community",
                            ProjectPhase = "Initial Installation: Aug 2013",
                            ProjectRegionalProgram = "Wells for South Sudan -NeverThirst",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 16L,
                            ProjectFunctionalityStatus = "Functional",
                            ProjectImpact = 500L,
                            ProjectName = "Teresia Primary School Water Project",
                            ProjectPhase = "In Service - Oct 2012",
                            ProjectRegionalProgram = "Wells for Kenya",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 17L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 500L,
                            ProjectName = "House of Hope Orphanage Well",
                            ProjectPhase = "Initial Installation: Aug 2011",
                            ProjectRegionalProgram = "Deep Wells -Kenya",
                            ProjectType = "Borehole Well and Submersible Pump"
                        },
                        new
                        {
                            ProjectId = 18L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 300L,
                            ProjectName = "Kakiriing Community Well",
                            ProjectPhase = "Initial Installation: Mar 2011",
                            ProjectRegionalProgram = "Wells for Kenya",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 19L,
                            ProjectFunctionalityStatus = "Low / No Water or Mechanical Breakdown",
                            ProjectImpact = 155L,
                            ProjectName = "St.Stephen Eshihaka Secondary School",
                            ProjectPhase = "In Service -Jan 2017",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Rainwater Catchment"
                        },
                        new
                        {
                            ProjectId = 20L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 500L,
                            ProjectName = "Musenyi Community Well",
                            ProjectPhase = "Initial Installation: Nov 2011",
                            ProjectRegionalProgram = "Wells for Rwanda",
                            ProjectType = "Borehole Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 21L,
                            ProjectFunctionalityStatus = "Under Community Care",
                            ProjectImpact = 300L,
                            ProjectName = "Vouregane Community",
                            ProjectPhase = "Initial Installation: Jan 2014",
                            ProjectRegionalProgram = "Wells for Burkina Faso",
                            ProjectType = "Well Rehab"
                        },
                        new
                        {
                            ProjectId = 22L,
                            ProjectFunctionalityStatus = "Under Community Care",
                            ProjectImpact = 250L,
                            ProjectName = "Soussoubro Community",
                            ProjectPhase = "Initial Installation: Aug 2014",
                            ProjectRegionalProgram = "Wells for Burkina Faso",
                            ProjectType = "Well Rehab"
                        },
                        new
                        {
                            ProjectId = 23L,
                            ProjectFunctionalityStatus = "Community Managed",
                            ProjectImpact = 500L,
                            ProjectName = "Kikoko Community Well",
                            ProjectPhase = "Initial Installation: Apr 2012",
                            ProjectRegionalProgram = "Wells for Masindi / Jinga Uganda",
                            ProjectType = "Dug Well and Hand Pump"
                        },
                        new
                        {
                            ProjectId = 24L,
                            ProjectFunctionalityStatus = "Water Flowing -Needs Attention",
                            ProjectImpact = 315L,
                            ProjectName = "Chegulo Community, Werabunuka Spring",
                            ProjectPhase = "In Service -Nov 2018",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Protected Spring"
                        },
                        new
                        {
                            ProjectId = 25L,
                            ProjectFunctionalityStatus = "Low / No Water or Mechanical Breakdown",
                            ProjectImpact = 500L,
                            ProjectName = "Khabukoshe Primary School",
                            ProjectPhase = "In Service -Apr 2019",
                            ProjectRegionalProgram = "Western Kenya WaSH Program",
                            ProjectType = "Rainwater Catchment"
                        });
                });

            modelBuilder.Entity("WaterProject.Models.CartLineItem", b =>
                {
                    b.HasOne("WaterProject.Models.Donation", null)
                        .WithMany("Lines")
                        .HasForeignKey("DonationId");

                    b.HasOne("WaterProject.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");
                });
#pragma warning restore 612, 618
        }
    }
}
