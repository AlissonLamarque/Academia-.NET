using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TestandoDBFirst;

public partial class BancoContext : DbContext
{
    public BancoContext()
    {
    }

    public BancoContext(DbContextOptions<BancoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=banco; User ID=aulaentity; password=senha_1234; language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clientes__3213E83FBC7F07A5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3213E83F5D56635F");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datapedido)
                .HasColumnType("date")
                .HasColumnName("datapedido");
            entity.Property(e => e.IdCliente).HasColumnName("id_Cliente");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK__Pedido__id_Clien__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
