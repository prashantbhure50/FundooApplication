﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RepositoryLayer.Interface;

namespace FundooApplication.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20210616092734_FundooApplication.Model.AddGenderPassword")]
    partial class FundooApplicationModelAddGenderPassword
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FundooApplication.Modle.UserModle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "Prasahantbhure50@gmail.com",
                            FirstName = "Prashant",
                            Gender = "Male",
                            LastName = "Bhure",
                            Password = "1234"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "dipesh.walte@bridgelabz.com",
                            FirstName = "Dipesh",
                            Gender = "Male",
                            LastName = "Walte",
                            Password = "9876"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
