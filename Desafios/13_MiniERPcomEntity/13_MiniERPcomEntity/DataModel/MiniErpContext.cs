using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _13_MiniERPcomEntity.DataModel;

public partial class MiniErpContext : DbContext
{
    public MiniErpContext()
    {
    }

    public MiniErpContext(DbContextOptions<MiniErpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Notum> Nota { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=MiniERP; User ID=aulaentity; password=senha_1234; language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__cliente__3213E83FFCC18F36");

            entity.ToTable("cliente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__forneced__3213E83FAD7015BA");

            entity.ToTable("fornecedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("cnpj");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Notum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__nota__3213E83FDB85BCD7");

            entity.ToTable("nota");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FkCliente).HasColumnName("fk_cliente");
            entity.Property(e => e.FkProduto).HasColumnName("fk_produto");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkCliente)
                .HasConstraintName("FK__nota__fk_cliente__4222D4EF");

            entity.HasOne(d => d.FkProdutoNavigation).WithMany(p => p.Nota)
                .HasForeignKey(d => d.FkProduto)
                .HasConstraintName("FK__nota__fk_cliente__412EB0B6");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__produto__3213E83F29CEFBEC");

            entity.ToTable("produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descricao");
            entity.Property(e => e.FkFornecedor).HasColumnName("fk_fornecedor");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valor");

            entity.HasOne(d => d.FkFornecedorNavigation).WithMany(p => p.Produtos)
                .HasForeignKey(d => d.FkFornecedor)
                .HasConstraintName("FK__produto__fk_forn__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
