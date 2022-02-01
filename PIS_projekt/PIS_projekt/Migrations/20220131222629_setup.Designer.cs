﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PIS_projekt.Models;

namespace PIS_projekt.Migrations
{
    [DbContext(typeof(LutaliceInfoSustavContext))]
    [Migration("20220131222629_setup")]
    partial class setup
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PIS_projekt.Models.Grad", b =>
                {
                    b.Property<int>("GradId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("grad_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivGrada")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Naziv_grada");

                    b.Property<int>("ZupanijaId")
                        .HasColumnType("int")
                        .HasColumnName("zupanija_id");

                    b.HasKey("GradId");

                    b.HasIndex("ZupanijaId");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("PIS_projekt.Models.IzgubljeneZivotinje", b =>
                {
                    b.Property<int>("IzgubljeneZivotinjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("izgubljene_zivotinje_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojMikrocipa")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("broj_mikrocipa");

                    b.Property<DateTime?>("DatumNestanka")
                        .HasColumnType("date")
                        .HasColumnName("Datum_nestanka");

                    b.Property<DateTime?>("DatumPrijave")
                        .HasColumnType("date")
                        .HasColumnName("Datum_prijave");

                    b.Property<int?>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("grad_id");

                    b.Property<string>("Ime")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("KastratId")
                        .HasColumnType("int")
                        .HasColumnName("kastrat_id");

                    b.Property<string>("Kontakt")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LokacijaNestanka")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Lokacija_nestanka");

                    b.Property<int?>("PasminaId")
                        .HasColumnType("int")
                        .HasColumnName("pasmina_id");

                    b.Property<string>("Slika")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SpolId")
                        .HasColumnType("int")
                        .HasColumnName("spol_id");

                    b.Property<int?>("VrstaZivotinjeId")
                        .HasColumnType("int")
                        .HasColumnName("vrsta_zivotinje_id");

                    b.HasKey("IzgubljeneZivotinjeId");

                    b.HasIndex("GradId");

                    b.HasIndex("KastratId");

                    b.HasIndex("PasminaId");

                    b.HasIndex("SpolId");

                    b.HasIndex("VrstaZivotinjeId");

                    b.ToTable("Izgubljene_zivotinje");
                });

            modelBuilder.Entity("PIS_projekt.Models.Kastrat", b =>
                {
                    b.Property<int>("KastratId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("kastrat_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JeLiKastrat")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnName("je_li_kastrat");

                    b.HasKey("KastratId");

                    b.ToTable("Kastrat");
                });

            modelBuilder.Entity("PIS_projekt.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("korisnik_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Email");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ime");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Lozinka");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Prezime");

                    b.Property<int?>("SklonisteFk")
                        .HasColumnType("int")
                        .HasColumnName("skloniste_fk");

                    b.Property<int>("UlogaFk")
                        .HasColumnType("int")
                        .HasColumnName("uloga_fk");

                    b.HasKey("KorisnikId");

                    b.HasIndex("SklonisteFk");

                    b.HasIndex("UlogaFk");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("PIS_projekt.Models.Pasmina", b =>
                {
                    b.Property<int>("PasminaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("pasmina_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivPasmine")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Naziv_pasmine");

                    b.Property<int?>("VrstaZivotinjeId")
                        .HasColumnType("int")
                        .HasColumnName("vrsta_zivotinje_id");

                    b.HasKey("PasminaId");

                    b.HasIndex("VrstaZivotinjeId");

                    b.ToTable("Pasmina");
                });

            modelBuilder.Entity("PIS_projekt.Models.Skloniste", b =>
                {
                    b.Property<int>("SklonisteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("skloniste_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("grad_id");

                    b.Property<string>("KapacitetSklonista")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("Kapacitet_sklonista");

                    b.Property<string>("NazivSklonista")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Naziv_sklonista");

                    b.Property<string>("Telefon")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SklonisteId");

                    b.HasIndex("GradId");

                    b.ToTable("Skloniste");
                });

            modelBuilder.Entity("PIS_projekt.Models.Spol", b =>
                {
                    b.Property<int>("SpolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("spol_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivSpola")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasColumnName("Naziv_spola");

                    b.HasKey("SpolId");

                    b.ToTable("Spol");
                });

            modelBuilder.Entity("PIS_projekt.Models.Udomljavanje", b =>
                {
                    b.Property<int>("UdomljavanjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("udomljavanje_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("JeLiZaUdomljavanje")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnName("je_li_za_udomljavanje");

                    b.HasKey("UdomljavanjeId");

                    b.ToTable("Udomljavanje");
                });

            modelBuilder.Entity("PIS_projekt.Models.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("uloga_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivUloge")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Naziv_uloge");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga");
                });

            modelBuilder.Entity("PIS_projekt.Models.UoceneLutalice", b =>
                {
                    b.Property<int>("UoceneLutaliceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("uocene_lutalice_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumPrijave")
                        .HasColumnType("date")
                        .HasColumnName("Datum_prijave");

                    b.Property<int>("GradId")
                        .HasColumnType("int")
                        .HasColumnName("grad_id");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("opis");

                    b.Property<string>("Slika")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("slika");

                    b.HasKey("UoceneLutaliceId");

                    b.HasIndex("GradId");

                    b.ToTable("Uocene_lutalice");
                });

            modelBuilder.Entity("PIS_projekt.Models.VrstaZivotinje", b =>
                {
                    b.Property<int>("VrstaZivotinjeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("vrsta_zivotinje_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivVrste")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Naziv_vrste");

                    b.HasKey("VrstaZivotinjeId");

                    b.ToTable("Vrsta_zivotinje");
                });

            modelBuilder.Entity("PIS_projekt.Models.ZivotinjaUSklonistu", b =>
                {
                    b.Property<int>("ZivotinjaUSklonistuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("zivotinja_u_sklonistu_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaPronalaska")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Adresa_pronalaska");

                    b.Property<string>("BrojMikrocipa")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("Broj_mikrocipa");

                    b.Property<DateTime?>("DatumPronalaska")
                        .HasColumnType("date")
                        .HasColumnName("Datum_pronalaska");

                    b.Property<DateTime?>("DatumStenjenja")
                        .HasColumnType("date")
                        .HasColumnName("Datum_stenjenja");

                    b.Property<string>("ImeZivotinje")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Ime_zivotinje");

                    b.Property<int?>("KastratId")
                        .HasColumnType("int")
                        .HasColumnName("kastrat_id");

                    b.Property<string>("Opis")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("PasminaId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("pasmina_id");

                    b.Property<int>("SklonisteId")
                        .HasColumnType("int")
                        .HasColumnName("skloniste_id");

                    b.Property<string>("Slika")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpolId")
                        .HasColumnType("int")
                        .HasColumnName("spol_id");

                    b.Property<int?>("UdomljavanjeId")
                        .HasColumnType("int")
                        .HasColumnName("udomljavanje_id");

                    b.HasKey("ZivotinjaUSklonistuId");

                    b.HasIndex("KastratId");

                    b.HasIndex("PasminaId");

                    b.HasIndex("SklonisteId");

                    b.HasIndex("SpolId");

                    b.HasIndex("UdomljavanjeId");

                    b.ToTable("Zivotinja_u_sklonistu");
                });

            modelBuilder.Entity("PIS_projekt.Models.Zupanija", b =>
                {
                    b.Property<int>("ZupanijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("zupanija_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivZupanije")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Naziv_zupanije");

                    b.HasKey("ZupanijaId");

                    b.ToTable("Zupanija");
                });

            modelBuilder.Entity("PIS_projekt.Models.Grad", b =>
                {
                    b.HasOne("PIS_projekt.Models.Zupanija", "Zupanija")
                        .WithMany("Grads")
                        .HasForeignKey("ZupanijaId")
                        .HasConstraintName("FK_Grad_Zupanija")
                        .IsRequired();

                    b.Navigation("Zupanija");
                });

            modelBuilder.Entity("PIS_projekt.Models.IzgubljeneZivotinje", b =>
                {
                    b.HasOne("PIS_projekt.Models.Grad", "Grad")
                        .WithMany("IzgubljeneZivotinjes")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Izgubljene_zivotinje_Grad");

                    b.HasOne("PIS_projekt.Models.Kastrat", "Kastrat")
                        .WithMany("IzgubljeneZivotinjes")
                        .HasForeignKey("KastratId")
                        .HasConstraintName("FK_Izgubljene_zivotinje_Kastrat");

                    b.HasOne("PIS_projekt.Models.Pasmina", "Pasmina")
                        .WithMany("IzgubljeneZivotinjes")
                        .HasForeignKey("PasminaId")
                        .HasConstraintName("FK_Izgubljene_zivotinje_Pasmina");

                    b.HasOne("PIS_projekt.Models.Spol", "Spol")
                        .WithMany("IzgubljeneZivotinjes")
                        .HasForeignKey("SpolId")
                        .HasConstraintName("FK_Izgubljene_zivotinje_Spol");

                    b.HasOne("PIS_projekt.Models.VrstaZivotinje", "VrstaZivotinje")
                        .WithMany("IzgubljeneZivotinjes")
                        .HasForeignKey("VrstaZivotinjeId")
                        .HasConstraintName("FK_Izgubljene_zivotinje_Vrsta_zivotinje");

                    b.Navigation("Grad");

                    b.Navigation("Kastrat");

                    b.Navigation("Pasmina");

                    b.Navigation("Spol");

                    b.Navigation("VrstaZivotinje");
                });

            modelBuilder.Entity("PIS_projekt.Models.Korisnik", b =>
                {
                    b.HasOne("PIS_projekt.Models.Skloniste", "Skloniste")
                        .WithMany("Korisniks")
                        .HasForeignKey("SklonisteFk")
                        .HasConstraintName("FK_Korisnik_Skloniste");

                    b.HasOne("PIS_projekt.Models.Uloga", "Uloga")
                        .WithMany("Korisniks")
                        .HasForeignKey("UlogaFk")
                        .HasConstraintName("FK_Korisnik_Uloga")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skloniste");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("PIS_projekt.Models.Pasmina", b =>
                {
                    b.HasOne("PIS_projekt.Models.VrstaZivotinje", "VrstaZivotinje")
                        .WithMany("Pasminas")
                        .HasForeignKey("VrstaZivotinjeId")
                        .HasConstraintName("FK_Pasmina_Vrsta_zivotinje");

                    b.Navigation("VrstaZivotinje");
                });

            modelBuilder.Entity("PIS_projekt.Models.Skloniste", b =>
                {
                    b.HasOne("PIS_projekt.Models.Grad", "Grad")
                        .WithMany("Sklonistes")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Skloniste_Grad")
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("PIS_projekt.Models.UoceneLutalice", b =>
                {
                    b.HasOne("PIS_projekt.Models.Grad", "Grad")
                        .WithMany("UoceneLutalices")
                        .HasForeignKey("GradId")
                        .HasConstraintName("FK_Uocene_lutalice_Grad")
                        .IsRequired();

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("PIS_projekt.Models.ZivotinjaUSklonistu", b =>
                {
                    b.HasOne("PIS_projekt.Models.Kastrat", "Kastrat")
                        .WithMany("ZivotinjaUSklonistus")
                        .HasForeignKey("KastratId")
                        .HasConstraintName("FK_Zivotinja_u_sklonistu_Kastrat");

                    b.HasOne("PIS_projekt.Models.Pasmina", "Pasmina")
                        .WithMany("ZivotinjaUSklonistus")
                        .HasForeignKey("PasminaId")
                        .HasConstraintName("FK_Zivotinja_u_sklonistu_Pasmina")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PIS_projekt.Models.Skloniste", "Skloniste")
                        .WithMany("ZivotinjaUSklonistus")
                        .HasForeignKey("SklonisteId")
                        .HasConstraintName("FK_Zivotinja_u_sklonistu_Skloniste")
                        .IsRequired();

                    b.HasOne("PIS_projekt.Models.Spol", "Spol")
                        .WithMany("ZivotinjaUSklonistus")
                        .HasForeignKey("SpolId")
                        .HasConstraintName("FK_Zivotinja_u_sklonistu_Spol")
                        .IsRequired();

                    b.HasOne("PIS_projekt.Models.Udomljavanje", "Udomljavanje")
                        .WithMany("ZivotinjaUSklonistus")
                        .HasForeignKey("UdomljavanjeId")
                        .HasConstraintName("FK_Zivotinja_u_sklonistu_Udomljavanje");

                    b.Navigation("Kastrat");

                    b.Navigation("Pasmina");

                    b.Navigation("Skloniste");

                    b.Navigation("Spol");

                    b.Navigation("Udomljavanje");
                });

            modelBuilder.Entity("PIS_projekt.Models.Grad", b =>
                {
                    b.Navigation("IzgubljeneZivotinjes");

                    b.Navigation("Sklonistes");

                    b.Navigation("UoceneLutalices");
                });

            modelBuilder.Entity("PIS_projekt.Models.Kastrat", b =>
                {
                    b.Navigation("IzgubljeneZivotinjes");

                    b.Navigation("ZivotinjaUSklonistus");
                });

            modelBuilder.Entity("PIS_projekt.Models.Pasmina", b =>
                {
                    b.Navigation("IzgubljeneZivotinjes");

                    b.Navigation("ZivotinjaUSklonistus");
                });

            modelBuilder.Entity("PIS_projekt.Models.Skloniste", b =>
                {
                    b.Navigation("Korisniks");

                    b.Navigation("ZivotinjaUSklonistus");
                });

            modelBuilder.Entity("PIS_projekt.Models.Spol", b =>
                {
                    b.Navigation("IzgubljeneZivotinjes");

                    b.Navigation("ZivotinjaUSklonistus");
                });

            modelBuilder.Entity("PIS_projekt.Models.Udomljavanje", b =>
                {
                    b.Navigation("ZivotinjaUSklonistus");
                });

            modelBuilder.Entity("PIS_projekt.Models.Uloga", b =>
                {
                    b.Navigation("Korisniks");
                });

            modelBuilder.Entity("PIS_projekt.Models.VrstaZivotinje", b =>
                {
                    b.Navigation("IzgubljeneZivotinjes");

                    b.Navigation("Pasminas");
                });

            modelBuilder.Entity("PIS_projekt.Models.Zupanija", b =>
                {
                    b.Navigation("Grads");
                });
#pragma warning restore 612, 618
        }
    }
}
