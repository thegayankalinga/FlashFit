﻿// <auto-generated />
using System;
using FlashFitClassLibrary.InitialData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlashFitClassLibrary.Migrations.CoreServicesApplicationDb
{
    [DbContext(typeof(CoreServicesApplicationDbContext))]
    [Migration("20230720190436_AddWorkoutTypeModelwithDBSEt")]
    partial class AddWorkoutTypeModelwithDBSEt
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FlashFitClassLibrary.Models.CheatmealModel", b =>
                {
                    b.Property<int>("CheatmealId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CheatmealId"));

                    b.Property<decimal>("CheatCalorieGain")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("CheatmealName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.HasKey("CheatmealId");

                    b.ToTable("CheatmealType");
                });

            modelBuilder.Entity("FlashFitClassLibrary.Models.WorkoutModel", b =>
                {
                    b.Property<int>("WorkoutID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkoutID"));

                    b.Property<decimal>("CaloryBurnRate")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkoutName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkoutType")
                        .IsRequired()
                        .HasColumnType("nvarchar(129)");

                    b.HasKey("WorkoutID");

                    b.ToTable("WorkoutType");
                });
#pragma warning restore 612, 618
        }
    }
}
