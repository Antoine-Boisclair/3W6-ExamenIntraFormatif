﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonApp_MVC.Data;

#nullable disable

namespace MonApp_MVC.Migrations
{
    [DbContext(typeof(MonAppDbContext))]
    [Migration("20250619133932_AjoutRelation2")]
    partial class AjoutRelation2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EquipeTournois", b =>
                {
                    b.Property<int>("EquipesId")
                        .HasColumnType("int");

                    b.Property<int>("TournoisId")
                        .HasColumnType("int");

                    b.HasKey("EquipesId", "TournoisId");

                    b.HasIndex("TournoisId");

                    b.ToTable("EquipeTournois");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Equipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Proprietaire")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Equipes");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.FicheOfficielle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Biographie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JoueurId")
                        .HasColumnType("int");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("FicheOfficielles");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Joueur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EquipeId")
                        .HasColumnType("int");

                    b.Property<int?>("FicheOfficielleId")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EquipeId");

                    b.ToTable("Joueurs");
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Tournois", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateDebut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.ToTable("Tournois");
                });

            modelBuilder.Entity("EquipeTournois", b =>
                {
                    b.HasOne("MonApp_MVC.Entities.Equipe", null)
                        .WithMany()
                        .HasForeignKey("EquipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonApp_MVC.Entities.Tournois", null)
                        .WithMany()
                        .HasForeignKey("TournoisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Joueur", b =>
                {
                    b.HasOne("MonApp_MVC.Entities.Equipe", null)
                        .WithMany("Joueurs")
                        .HasForeignKey("EquipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonApp_MVC.Entities.Equipe", b =>
                {
                    b.Navigation("Joueurs");
                });
#pragma warning restore 612, 618
        }
    }
}
