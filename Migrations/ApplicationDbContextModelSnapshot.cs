﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using gradeManagerServerAPi.Data.UserManagementAPI.Data;

#nullable disable

namespace gradeManagerServerAPi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Classe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiliereId")
                        .HasColumnType("int");

                    b.Property<int>("GradeId")
                        .HasColumnType("int");

                    b.Property<int>("NiveauId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.HasIndex("GradeId");

                    b.HasIndex("NiveauId");

                    b.HasIndex("SpecialiteId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Faculte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Facultes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Departement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FaculteId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FaculteId");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartementId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartementId");

                    b.ToTable("Filieres");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiliereId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Niveau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiliereId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.ToTable("Niveaux");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Specialite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FiliereId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("FiliereId");

                    b.ToTable("Specialites");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.UE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("int");

                    b.Property<int>("Coef")
                        .HasColumnType("int");

                    b.Property<int?>("InscriptionId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .HasColumnType("longtext");

                    b.Property<int>("Semestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.HasIndex("InscriptionId");

                    b.ToTable("UEs");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Etudiant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClasseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.ToTable("Etudiants");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Inscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClasseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateInscription")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EstValide")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("EtudiantId")
                        .HasColumnType("int");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("UeIds")
                        .HasColumnType("longtext");

                    b.Property<int>("semestre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClasseId");

                    b.HasIndex("EtudiantId");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.UserConnexion.UserInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserInfos");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Services.UserService._2FA.ValidationCode2FA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("HashedCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ValidationCodes");
                });

            modelBuilder.Entity("Classe", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", "Filiere")
                        .WithMany("Classes")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Niveau", "Niveau")
                        .WithMany()
                        .HasForeignKey("NiveauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Specialite", "Specialite")
                        .WithMany()
                        .HasForeignKey("SpecialiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");

                    b.Navigation("Grade");

                    b.Navigation("Niveau");

                    b.Navigation("Specialite");
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
                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", null)
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

                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Departement", b =>
                {
                    b.HasOne("Faculte", "Faculte")
                        .WithMany("Departements")
                        .HasForeignKey("FaculteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculte");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Departement", "Departement")
                        .WithMany("Filieres")
                        .HasForeignKey("DepartementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departement");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Grade", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", "Filiere")
                        .WithMany("Grades")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Niveau", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", "Filiere")
                        .WithMany("Niveaux")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Specialite", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", "Filiere")
                        .WithMany("Specialites")
                        .HasForeignKey("FiliereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filiere");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.UE", b =>
                {
                    b.HasOne("Classe", "Classe")
                        .WithMany("UEs")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("gradeManagerServerAPi.Models.StudentM.Inscription", null)
                        .WithMany("Ues")
                        .HasForeignKey("InscriptionId");

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Etudiant", b =>
                {
                    b.HasOne("Classe", "Classe")
                        .WithMany("Etudiants")
                        .HasForeignKey("ClasseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classe");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Inscription", b =>
                {
                    b.HasOne("Classe", null)
                        .WithMany("Inscriptions")
                        .HasForeignKey("ClasseId");

                    b.HasOne("gradeManagerServerAPi.Models.StudentM.Etudiant", "Etudiant")
                        .WithMany("Inscriptions")
                        .HasForeignKey("EtudiantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Etudiant");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.UserConnexion.UserInfo", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", "User")
                        .WithOne()
                        .HasForeignKey("gradeManagerServerAPi.Models.UserConnexion.UserInfo", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Services.UserService._2FA.ValidationCode2FA", b =>
                {
                    b.HasOne("gradeManagerServerAPi.Models.UserConnexion.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Classe", b =>
                {
                    b.Navigation("Etudiants");

                    b.Navigation("Inscriptions");

                    b.Navigation("UEs");
                });

            modelBuilder.Entity("Faculte", b =>
                {
                    b.Navigation("Departements");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Departement", b =>
                {
                    b.Navigation("Filieres");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.AdministrationM.GestionAcademique.Filiere", b =>
                {
                    b.Navigation("Classes");

                    b.Navigation("Grades");

                    b.Navigation("Niveaux");

                    b.Navigation("Specialites");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Etudiant", b =>
                {
                    b.Navigation("Inscriptions");
                });

            modelBuilder.Entity("gradeManagerServerAPi.Models.StudentM.Inscription", b =>
                {
                    b.Navigation("Ues");
                });
#pragma warning restore 612, 618
        }
    }
}
