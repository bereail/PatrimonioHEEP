﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PatrimonioAPI.Models;

public partial class InventarioDBContext : DbContext
{
    public InventarioDBContext(DbContextOptions<InventarioDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<CajaChica> CajaChicas { get; set; }

    public virtual DbSet<Carga> Cargas { get; set; }

    public virtual DbSet<CodigoComputo> CodigoComputos { get; set; }

    public virtual DbSet<Component> Components { get; set; }

    public virtual DbSet<ComponentesHistoriale> ComponentesHistoriales { get; set; }

    public virtual DbSet<MetodosAdquisicion> MetodosAdquisicions { get; set; }

    public virtual DbSet<Pc> Pcs { get; set; }

    public virtual DbSet<PcHistoriale> PcHistoriales { get; set; }

    public virtual DbSet<PcNombre> PcNombres { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Toner> Toners { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__articulo__3213E83FCA089286");

            entity.ToTable("articulos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Descripcion)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<CajaChica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__caja_chi__3213E83F2FED0D43");

            entity.ToTable("caja_chica");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.NumCaja)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_caja");
            entity.Property(e => e.Pago).HasColumnName("pago");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.CajaChicas)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK_caja_chica_proveedor");
        });

        modelBuilder.Entity<Carga>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Carga__3214EC0767AA9F39");

            entity.ToTable("cargas");

            entity.Property(e => e.Fecha).HasColumnType("datetime");

            entity.HasOne(d => d.IdServiceNavigation).WithMany(p => p.Cargas)
                .HasForeignKey(d => d.IdService)
                .HasConstraintName("FK__Carga__IdService__3F466844");

            entity.HasOne(d => d.IdTonerNavigation).WithMany(p => p.Cargas)
                .HasForeignKey(d => d.IdToner)
                .HasConstraintName("FK__Carga__IdToner__403A8C7D");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Cargas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Carga__IdUsuario__3E52440B");
        });

        modelBuilder.Entity<CodigoComputo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__codigo_c__3213E83FE8848638");

            entity.ToTable("codigo_computos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
        });

        modelBuilder.Entity<Component>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__componen__3213E83FC627EDAD");

            entity.ToTable("components");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EstadoActivo).HasColumnName("estado_activo");
            entity.Property(e => e.IdArticulos).HasColumnName("id_articulos");
            entity.Property(e => e.IdCodigoComputos).HasColumnName("id_codigo_computos");
            entity.Property(e => e.IdHistorialComponente).HasColumnName("id_historial_componente");
            entity.Property(e => e.IdMetodoAdquisicion).HasColumnName("id_metodo_adquisicion");
            entity.Property(e => e.NumPatrimonio)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_patrimonio");

            entity.HasOne(d => d.IdArticulosNavigation).WithMany(p => p.Components)
                .HasForeignKey(d => d.IdArticulos)
                .HasConstraintName("FK_components_articulos");

            entity.HasOne(d => d.IdCodigoComputosNavigation).WithMany(p => p.Components)
                .HasForeignKey(d => d.IdCodigoComputos)
                .HasConstraintName("FK_components_codigo_computos");

            entity.HasOne(d => d.IdHistorialComponenteNavigation).WithMany(p => p.Components)
                .HasForeignKey(d => d.IdHistorialComponente)
                .HasConstraintName("FK_components_historial_componente");

            entity.HasOne(d => d.IdMetodoAdquisicionNavigation).WithMany(p => p.Components)
                .HasForeignKey(d => d.IdMetodoAdquisicion)
                .HasConstraintName("FK_components_metodo_adquisicion");
        });

        modelBuilder.Entity<ComponentesHistoriale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__componen__3213E83F6DA4C85E");

            entity.ToTable("componentes_historiales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<MetodosAdquisicion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__metodos___3213E83F73343094");

            entity.ToTable("metodos_adquisicion");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdCajaChica).HasColumnName("id_caja_chica");
            entity.Property(e => e.IdPedido).HasColumnName("id_pedido");
            entity.Property(e => e.Otro)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("otro");

            entity.HasOne(d => d.IdCajaChicaNavigation).WithMany(p => p.MetodosAdquisicions)
                .HasForeignKey(d => d.IdCajaChica)
                .HasConstraintName("FK_metodos_adquisicion_caja_chica");

            entity.HasOne(d => d.IdPedidoNavigation).WithMany(p => p.MetodosAdquisicions)
                .HasForeignKey(d => d.IdPedido)
                .HasConstraintName("FK_metodos_adquisicion_pedido");
        });

        modelBuilder.Entity<Pc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pc__3213E83F22923F91");

            entity.ToTable("pc");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IdComponent).HasColumnName("id_component");
            entity.Property(e => e.IdPcHistorial).HasColumnName("id_pc_historial");
            entity.Property(e => e.IdPcNombres).HasColumnName("id_pc_nombres");
            entity.Property(e => e.IdServices).HasColumnName("id_services");

            entity.HasOne(d => d.IdComponentNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdComponent)
                .HasConstraintName("FK_pc_components");

            entity.HasOne(d => d.IdPcHistorialNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdPcHistorial)
                .HasConstraintName("FK_pc_pc_historial");

            entity.HasOne(d => d.IdPcNombresNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdPcNombres)
                .HasConstraintName("FK_pc_pc_nombres");

            entity.HasOne(d => d.IdServicesNavigation).WithMany(p => p.Pcs)
                .HasForeignKey(d => d.IdServices)
                .HasConstraintName("FK_pc_services");
        });

        modelBuilder.Entity<PcHistoriale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pc_histo__3213E83FF50BDB41");

            entity.ToTable("pc_historiales");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.PcHistoriales)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("FK_pc_historiales_user");
        });

        modelBuilder.Entity<PcNombre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pc_nombr__3213E83F92C1D106");

            entity.ToTable("pc_nombres");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ip");
            entity.Property(e => e.UserPc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("user_pc");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pedidos__3213E83F7F97B2DC");

            entity.ToTable("pedidos");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
            entity.Property(e => e.IdProveedor).HasColumnName("id_proveedor");
            entity.Property(e => e.NumOp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_op");
            entity.Property(e => e.NumPedido)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("num_pedido");

            entity.HasOne(d => d.IdProveedorNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdProveedor)
                .HasConstraintName("FK_pedidos_proveedor");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__proveedo__3213E83F317BB2AD");

            entity.ToTable("proveedores");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Contacto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("contacto");
            entity.Property(e => e.Historial)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("historial");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Service__3214EC071A192842");

            entity.ToTable("servicios");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Toner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Toner__3214EC07D20D831B");

            entity.ToTable("toners");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07BD8804B0");

            entity.ToTable("users");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E487E76B5B").IsUnique();

            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}