using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contas2.Models;

namespace Contas2.DB
{
    public class ContasContext : DbContext
    {
        public ContasContext(DbContextOptions<ContasContext> options) : base(options)
        {
        }
        public DbSet<Contas> Contas { get; set; }

        public DbSet<Fornecedor> Fornecedor { get; set; }

        public DbSet<Parcelamento> Parcelamento { get; set; }

        public DbSet<Parcelas> Parcela { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //       modelBuilder.Entity<Contas>(etd =>
            //{
            //    etd.ToTable("tbCliente");
            //    etd.HasKey(c => c.IdContas).HasName("IdContas");
            //    etd.Property(c => c.IdContas).HasColumnName("IdContas").ValueGeneratedOnAdd();
            //    etd.Property(c => c.ValorTotal).HasColumnName("ValorTotal");

            //});
            //       modelBuilder.Entity<Fornecedor>(etd =>
            //{
            //    etd.ToTable("Fornecedor");
            //    etd.HasKey(p => p.IdFornecedor).HasName("IdFornecedor");
            //    etd.Property(p => p.IdFornecedor).HasColumnName("IdFornecedor").ValueGeneratedOnAdd();
            //    etd.Property(p => p.NomeFornecedor).HasColumnName("NomeFornecedor");
            //    //etd.HasOne(c => c.).WithMany(p => p.Pedidos);
            //});
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = optionsBuilder.UseSqlServer("Server=LAPTOP-BLG780OV;Database=Contas;Trusted_Connection=True;");
        }
    }
}
