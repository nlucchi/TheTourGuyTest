﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheTourGuyTest.Data;

#nullable disable

namespace TheTourGuyTest.Data.Migrations
{
    [DbContext(typeof(TheTourGuyDbContext))]
    [Migration("20220630142307_initial-create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Climate", b =>
                {
                    b.Property<int>("ClimateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClimateId"), 1L, 1);

                    b.Property<string>("ClimateName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ClimateId");

                    b.ToTable("Climates");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("PlanetId");

                    b.HasIndex("RoleId");

                    b.HasIndex("TeamId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Planet", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanetId"), 1L, 1);

                    b.Property<int>("ClimateId")
                        .HasColumnType("int");

                    b.Property<string>("PlanetName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PlanetId");

                    b.HasIndex("ClimateId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Relation", b =>
                {
                    b.Property<int>("RelationTypeId")
                        .HasColumnType("int");

                    b.Property<int>("RelationSubjectId")
                        .HasColumnType("int");

                    b.Property<int>("RelationObjectId")
                        .HasColumnType("int");

                    b.HasKey("RelationTypeId", "RelationSubjectId", "RelationObjectId");

                    b.HasIndex("RelationObjectId");

                    b.HasIndex("RelationSubjectId");

                    b.ToTable("Relations");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.RelationType", b =>
                {
                    b.Property<int>("RelationTypeId")
                        .HasColumnType("int");

                    b.Property<string>("RelationName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RelationTypeId");

                    b.ToTable("RelationTypes");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamId"), 1L, 1);

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Person", b =>
                {
                    b.HasOne("TheTourGuyTest.Domain.Models.Planet", "Planet")
                        .WithMany("Persons")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheTourGuyTest.Domain.Models.Role", "Role")
                        .WithMany("Persons")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TheTourGuyTest.Domain.Models.Team", "Team")
                        .WithMany("Persons")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");

                    b.Navigation("Role");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Planet", b =>
                {
                    b.HasOne("TheTourGuyTest.Domain.Models.Climate", "Climate")
                        .WithMany("Planets")
                        .HasForeignKey("ClimateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Climate");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Relation", b =>
                {
                    b.HasOne("TheTourGuyTest.Domain.Models.Person", "RelationObject")
                        .WithMany("RelationsObjectOf")
                        .HasForeignKey("RelationObjectId")
                        .IsRequired();

                    b.HasOne("TheTourGuyTest.Domain.Models.Person", "RelationSubject")
                        .WithMany("RelationsSubjectOf")
                        .HasForeignKey("RelationSubjectId")
                        .IsRequired();

                    b.HasOne("TheTourGuyTest.Domain.Models.RelationType", null)
                        .WithMany("Relations")
                        .HasForeignKey("RelationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RelationObject");

                    b.Navigation("RelationSubject");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Climate", b =>
                {
                    b.Navigation("Planets");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Person", b =>
                {
                    b.Navigation("RelationsObjectOf");

                    b.Navigation("RelationsSubjectOf");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Planet", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.RelationType", b =>
                {
                    b.Navigation("Relations");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Role", b =>
                {
                    b.Navigation("Persons");
                });

            modelBuilder.Entity("TheTourGuyTest.Domain.Models.Team", b =>
                {
                    b.Navigation("Persons");
                });
#pragma warning restore 612, 618
        }
    }
}
