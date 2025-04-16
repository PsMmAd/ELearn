﻿// <auto-generated />
using System;
using ELearn.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELearn.DataLayer.Migrations
{
    [DbContext(typeof(ELearnContext))]
    [Migration("20250409082250_initialDataBase")]
    partial class initialDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ELearn.DataLayer.Entities.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"), 1L, 1);

                    b.Property<int>("CourseDescription")
                        .HasColumnType("int");

                    b.Property<int>("CourseGroupId")
                        .HasColumnType("int");

                    b.Property<string>("CourseThumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseTitel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("bit");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<DateTimeOffset>("PublishDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("SellCount")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("CourseGroupId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.CourseGroup", b =>
                {
                    b.Property<int>("CourseGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseGroupId"), 1L, 1);

                    b.Property<string>("CourseGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseGroupId");

                    b.ToTable("CourseGroups");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.CourseSeason", b =>
                {
                    b.Property<int>("CourseSeasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseSeasonId"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("CourseSeasonTitel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseSeasonId");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseSeasons");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("CourseSeasonId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFree")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("PublishDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VideoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("CourseSeasonId");

                    b.ToTable("Episodes");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.Course", b =>
                {
                    b.HasOne("ELearn.DataLayer.Entities.CourseGroup", "CourseGroup")
                        .WithMany("Course")
                        .HasForeignKey("CourseGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseGroup");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.CourseSeason", b =>
                {
                    b.HasOne("ELearn.DataLayer.Entities.Course", "Course")
                        .WithMany("CourseSeasons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.Episode", b =>
                {
                    b.HasOne("ELearn.DataLayer.Entities.CourseSeason", "CourseSeason")
                        .WithMany("Episodes")
                        .HasForeignKey("CourseSeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseSeason");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.Course", b =>
                {
                    b.Navigation("CourseSeasons");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.CourseGroup", b =>
                {
                    b.Navigation("Course");
                });

            modelBuilder.Entity("ELearn.DataLayer.Entities.CourseSeason", b =>
                {
                    b.Navigation("Episodes");
                });
#pragma warning restore 612, 618
        }
    }
}
