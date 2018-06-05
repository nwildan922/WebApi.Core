﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Core.DataContext;

namespace WebApi.Core.Migrations
{
    [DbContext(typeof(MhsContext))]
    [Migration("20180605151929_InitialModels")]
    partial class InitialModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi.Core.Models.MahasiswaModel", b =>
                {
                    b.Property<string>("Nim")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alamat")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Nama")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Nim");

                    b.ToTable("Mahasiswas");
                });
#pragma warning restore 612, 618
        }
    }
}
