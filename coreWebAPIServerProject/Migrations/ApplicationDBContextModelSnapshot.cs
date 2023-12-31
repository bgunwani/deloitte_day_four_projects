﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using coreWebAPIServerProject.Models;

#nullable disable

namespace coreWebAPIServerProject.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("coreWebAPIServerProject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<int>("ProductQuantity")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 101,
                            ProductName = "Keyboard",
                            ProductPrice = 2000.0,
                            ProductQuantity = 10
                        },
                        new
                        {
                            ProductId = 102,
                            ProductName = "Mouse",
                            ProductPrice = 1500.0,
                            ProductQuantity = 20
                        },
                        new
                        {
                            ProductId = 103,
                            ProductName = "HardDisk",
                            ProductPrice = 3500.0,
                            ProductQuantity = 10
                        },
                        new
                        {
                            ProductId = 104,
                            ProductName = "Sanner",
                            ProductPrice = 4000.0,
                            ProductQuantity = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
