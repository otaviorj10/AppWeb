using AppWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.ClassContext
{
    public class AppWebContext:DbContext
    {


        public DbSet<AlunoModel> Aluno { get; set; }
        public DbSet<Prova> Prova { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppWebContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlunoModel>().HasKey(p=>p.AlunoId);
            modelBuilder.Entity<Prova>().HasKey(p=>p.ProvaId);

            modelBuilder.Entity<AlunoModel>()
                .HasOne(aluno => aluno.Prova)
                .WithOne(prova => prova.Aluno)
                .HasForeignKey<Prova>(prova => prova.AlunoId);
        }

    }
}
