﻿// <auto-generated />
using AppWeb.ClassContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppWeb.Migrations
{
    [DbContext(typeof(AppWebContext))]
    partial class AppWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppWeb.Models.AlunoModel", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAluno")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("AppWeb.Models.Prova", b =>
                {
                    b.Property<int>("ProvaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId")
                        .HasColumnType("int");

                    b.Property<string>("Materia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.HasKey("ProvaId");

                    b.HasIndex("AlunoId")
                        .IsUnique();

                    b.ToTable("Prova");
                });

            modelBuilder.Entity("AppWeb.Models.Prova", b =>
                {
                    b.HasOne("AppWeb.Models.AlunoModel", "Aluno")
                        .WithOne("Prova")
                        .HasForeignKey("AppWeb.Models.Prova", "AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aluno");
                });

            modelBuilder.Entity("AppWeb.Models.AlunoModel", b =>
                {
                    b.Navigation("Prova");
                });
#pragma warning restore 612, 618
        }
    }
}
