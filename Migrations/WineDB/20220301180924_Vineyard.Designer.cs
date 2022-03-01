﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcWineAPP.Data;

namespace MvcWineAPP.Migrations.WineDB
{
    [DbContext(typeof(WineDBContext))]
    [Migration("20220301180924_Vineyard")]
    partial class Vineyard
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcWineAPP.Models.Wine", b =>
                {
                    b.Property<int>("WineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DateAdded")
                        .HasColumnType("int");

                    b.Property<string>("PairsWith")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vineyard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WineTypes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WineVintage")
                        .HasColumnType("int");

                    b.HasKey("WineID");

                    b.ToTable("Wine");
                });
#pragma warning restore 612, 618
        }
    }
}
