﻿// <auto-generated />
using System;
using Kolokwium.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kolokwium.Migrations
{
    [DbContext(typeof(FootballDbContext))]
    [Migration("20200620185558_FootballTable")]
    partial class FootballTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kolokwium.Models.Championship", b =>
                {
                    b.Property<int>("IdChampionship")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficialName");

                    b.Property<int>("Year");

                    b.HasKey("IdChampionship");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("Kolokwium.Models.Championship_Team", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdChampionship");

                    b.Property<float>("Score");

                    b.Property<int?>("TeamIdTeam");

                    b.HasKey("IdTeam");

                    b.HasIndex("IdChampionship");

                    b.HasIndex("TeamIdTeam");

                    b.ToTable("Championship_Teams");
                });

            modelBuilder.Entity("Kolokwium.Models.Player", b =>
                {
                    b.Property<int>("IdPlayer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("IdPlayer");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Kolokwium.Models.Player_Team", b =>
                {
                    b.Property<int>("IdPlayer")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment");

                    b.Property<int>("IdTeam");

                    b.Property<int>("NumOnShirt");

                    b.Property<int?>("PlayerIdPlayer");

                    b.HasKey("IdPlayer");

                    b.HasIndex("IdTeam");

                    b.HasIndex("PlayerIdPlayer");

                    b.ToTable("Player_Teams");
                });

            modelBuilder.Entity("Kolokwium.Models.Team", b =>
                {
                    b.Property<int>("IdTeam")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaxAge");

                    b.Property<string>("TeamName");

                    b.HasKey("IdTeam");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Kolokwium.Models.Championship_Team", b =>
                {
                    b.HasOne("Kolokwium.Models.Championship", "Championship")
                        .WithMany("Championship_Teams")
                        .HasForeignKey("IdChampionship")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kolokwium.Models.Team", "Team")
                        .WithMany("Championship_Teams")
                        .HasForeignKey("TeamIdTeam");
                });

            modelBuilder.Entity("Kolokwium.Models.Player_Team", b =>
                {
                    b.HasOne("Kolokwium.Models.Team", "Team")
                        .WithMany("Player_Teams")
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Kolokwium.Models.Player", "Player")
                        .WithMany("Player_Teams")
                        .HasForeignKey("PlayerIdPlayer");
                });
#pragma warning restore 612, 618
        }
    }
}
