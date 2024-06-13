﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(TurContext))]
    partial class TurContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.Adres", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("AdresAdı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mahalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sokak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.Property<string>("İl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("İlçe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TurID");

                    b.ToTable("Adresler");
                });

            modelBuilder.Entity("DataAccess.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<bool>("CommercialEmailsAccepted")
                        .HasColumnType("bit");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TermsAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Fatura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BelgeNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DuzenlenmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("TahsilatID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("TahsilatID");

                    b.ToTable("Faturalar");
                });

            modelBuilder.Entity("DataAccess.Models.GeziProgramı", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("KacGun")
                        .HasColumnType("int");

                    b.Property<int>("KacKisilik")
                        .HasColumnType("int");

                    b.Property<string>("KalinacakYer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeyahatIpuculari")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.Property<string>("Vasita")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TurID");

                    b.ToTable("GeziProgramlari");
                });

            modelBuilder.Entity("DataAccess.Models.Lokasyon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("BulunduguUlkeID")
                        .HasColumnType("int");

                    b.Property<string>("TurLokasyonu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BulunduguUlkeID");

                    b.ToTable("Lokasyonlar");
                });

            modelBuilder.Entity("DataAccess.Models.Personel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kidem")
                        .HasColumnType("int");

                    b.Property<decimal>("Maas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MaasGunu")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Personeller");
                });

            modelBuilder.Entity("DataAccess.Models.Rezervasyon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Odendi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RezervasyonTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("TurID");

                    b.HasIndex("UserID");

                    b.ToTable("Rezervasyonlar");
                });

            modelBuilder.Entity("DataAccess.Models.Tahsilat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("TahsilatTuruID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Tutar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("TahsilatTuruID");

                    b.ToTable("Tahsilatlar");
                });

            modelBuilder.Entity("DataAccess.Models.TahsilatTuru", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TahsilatTurleri");
                });

            modelBuilder.Entity("DataAccess.Models.Tur", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AktifMi")
                        .HasColumnType("bit");

                    b.Property<string>("Açıklama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TurAltKategoriID")
                        .HasColumnType("int");

                    b.Property<int?>("TurKategoriID")
                        .HasColumnType("int");

                    b.Property<bool>("YurtDışıMı")
                        .HasColumnType("bit");

                    b.Property<bool>("YurtİçiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ÜyeOluşTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("TurAltKategoriID");

                    b.HasIndex("TurKategoriID");

                    b.ToTable("Turlar");
                });

            modelBuilder.Entity("DataAccess.Models.TurAltKategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TurAltKategorileri");
                });

            modelBuilder.Entity("DataAccess.Models.TurKategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TurKategorileri");
                });

            modelBuilder.Entity("DataAccess.Models.TuraKayit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<decimal>("BrutFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Indirim")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("KayitNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NetFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TurID");

                    b.ToTable("TuraKayitlar");
                });

            modelBuilder.Entity("DataAccess.Models.Ulke", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ulkeler");
                });

            modelBuilder.Entity("DataAccess.Models.Yorum", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Puan")
                        .HasColumnType("int");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("YorumTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("TurID");

                    b.HasIndex("UserID");

                    b.ToTable("Yorumlar");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DataAccess.Models.Adres", b =>
                {
                    b.HasOne("DataAccess.Models.Tur", "Tur")
                        .WithMany("Adresler")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("DataAccess.Models.Fatura", b =>
                {
                    b.HasOne("DataAccess.Models.Tahsilat", "Tahsilat")
                        .WithMany("Faturalar")
                        .HasForeignKey("TahsilatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tahsilat");
                });

            modelBuilder.Entity("DataAccess.Models.GeziProgramı", b =>
                {
                    b.HasOne("DataAccess.Models.Tur", "Tur")
                        .WithMany("GeziProgramları")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("DataAccess.Models.Lokasyon", b =>
                {
                    b.HasOne("DataAccess.Models.Ulke", "BulunduguUlke")
                        .WithMany("Lokasyonlar")
                        .HasForeignKey("BulunduguUlkeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BulunduguUlke");
                });

            modelBuilder.Entity("DataAccess.Models.Rezervasyon", b =>
                {
                    b.HasOne("DataAccess.Models.Tur", "Tur")
                        .WithMany("Rezervasyonlar")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.ApplicationUser", "User")
                        .WithMany("Rezervasyonlar")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataAccess.Models.Tahsilat", b =>
                {
                    b.HasOne("DataAccess.Models.TahsilatTuru", "TahsilatTuru")
                        .WithMany("Tahsilatlar")
                        .HasForeignKey("TahsilatTuruID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TahsilatTuru");
                });

            modelBuilder.Entity("DataAccess.Models.Tur", b =>
                {
                    b.HasOne("DataAccess.Models.TurAltKategori", null)
                        .WithMany("Turlar")
                        .HasForeignKey("TurAltKategoriID");

                    b.HasOne("DataAccess.Models.TurKategori", null)
                        .WithMany("Turlar")
                        .HasForeignKey("TurKategoriID");
                });

            modelBuilder.Entity("DataAccess.Models.TuraKayit", b =>
                {
                    b.HasOne("DataAccess.Models.Tur", "Tur")
                        .WithMany("TuraKayitlar")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");
                });

            modelBuilder.Entity("DataAccess.Models.Yorum", b =>
                {
                    b.HasOne("DataAccess.Models.Tur", "Tur")
                        .WithMany("Yorumlar")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.ApplicationUser", "User")
                        .WithMany("Yorumlar")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tur");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DataAccess.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.ApplicationUser", b =>
                {
                    b.Navigation("Rezervasyonlar");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("DataAccess.Models.Tahsilat", b =>
                {
                    b.Navigation("Faturalar");
                });

            modelBuilder.Entity("DataAccess.Models.TahsilatTuru", b =>
                {
                    b.Navigation("Tahsilatlar");
                });

            modelBuilder.Entity("DataAccess.Models.Tur", b =>
                {
                    b.Navigation("Adresler");

                    b.Navigation("GeziProgramları");

                    b.Navigation("Rezervasyonlar");

                    b.Navigation("TuraKayitlar");

                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("DataAccess.Models.TurAltKategori", b =>
                {
                    b.Navigation("Turlar");
                });

            modelBuilder.Entity("DataAccess.Models.TurKategori", b =>
                {
                    b.Navigation("Turlar");
                });

            modelBuilder.Entity("DataAccess.Models.Ulke", b =>
                {
                    b.Navigation("Lokasyonlar");
                });
#pragma warning restore 612, 618
        }
    }
}
