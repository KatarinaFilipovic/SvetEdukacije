// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjekatAPI.Models;

namespace ProjekatAPI.Migrations
{
    [DbContext(typeof(PredavacContext))]
    [Migration("20200614192434_v17")]
    partial class v17
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjekatAPI.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Poruka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PredavacId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UcenikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Poruke");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Predavac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brtel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OceneMinus")
                        .HasColumnType("int");

                    b.Property<int>("OcenePlus")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Predavaci");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PredavacId")
                        .HasColumnType("int");

                    b.Property<string>("Skola")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PredavacId");

                    b.ToTable("Predmeti");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Ucenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brtel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ucenik");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Zahtev", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Glasano")
                        .HasColumnType("bit");

                    b.Property<int?>("PredavacId")
                        .HasColumnType("int");

                    b.Property<string>("Predmet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Prihvacen")
                        .HasColumnType("bit");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UcenikId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PredavacId");

                    b.HasIndex("UcenikId");

                    b.ToTable("Zahtevi");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Predmet", b =>
                {
                    b.HasOne("ProjekatAPI.Models.Predavac", "Predavac")
                        .WithMany("Predmeti")
                        .HasForeignKey("PredavacId");
                });

            modelBuilder.Entity("ProjekatAPI.Models.Zahtev", b =>
                {
                    b.HasOne("ProjekatAPI.Models.Predavac", "Predavac")
                        .WithMany()
                        .HasForeignKey("PredavacId");

                    b.HasOne("ProjekatAPI.Models.Ucenik", "Ucenik")
                        .WithMany()
                        .HasForeignKey("UcenikId");
                });
#pragma warning restore 612, 618
        }
    }
}
