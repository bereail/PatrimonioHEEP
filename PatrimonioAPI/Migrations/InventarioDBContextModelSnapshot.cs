﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatrimonioAPI.Models;

#nullable disable

namespace PatrimonioAPI.Migrations
{
    [DbContext(typeof(InventarioDBContext))]
    partial class InventarioDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PatrimonioAPI.Models.Articulo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int")
                        .HasColumnName("cantidad");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("descripcion");

                    b.HasKey("Id")
                        .HasName("PK__articulo__3213E83FCA089286");

                    b.ToTable("articulos", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.CajaChica", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("fecha");

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int")
                        .HasColumnName("id_proveedor");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("monto");

                    b.Property<string>("NumCaja")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("num_caja");

                    b.Property<bool?>("Pago")
                        .HasColumnType("bit")
                        .HasColumnName("pago");

                    b.HasKey("Id")
                        .HasName("PK__caja_chi__3213E83F2FED0D43");

                    b.HasIndex("IdProveedor");

                    b.ToTable("caja_chica", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Carga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Cantidad")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int?>("IdService")
                        .HasColumnType("int");

                    b.Property<int?>("IdToner")
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Carga__3214EC0767AA9F39");

                    b.HasIndex("IdService");

                    b.HasIndex("IdToner");

                    b.HasIndex("IdUsuario");

                    b.ToTable("cargas", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.CodigoComputo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Codigo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("codigo");

                    b.HasKey("Id")
                        .HasName("PK__codigo_c__3213E83FE8848638");

                    b.ToTable("codigo_computos", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<bool?>("EstadoActivo")
                        .HasColumnType("bit")
                        .HasColumnName("estado_activo");

                    b.Property<int?>("IdArticulos")
                        .HasColumnType("int")
                        .HasColumnName("id_articulos");

                    b.Property<int?>("IdCodigoComputos")
                        .HasColumnType("int")
                        .HasColumnName("id_codigo_computos");

                    b.Property<int?>("IdHistorialComponente")
                        .HasColumnType("int")
                        .HasColumnName("id_historial_componente");

                    b.Property<int?>("IdMetodoAdquisicion")
                        .HasColumnType("int")
                        .HasColumnName("id_metodo_adquisicion");

                    b.Property<string>("NumPatrimonio")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("num_patrimonio");

                    b.HasKey("Id")
                        .HasName("PK__componen__3213E83FC627EDAD");

                    b.HasIndex("IdArticulos");

                    b.HasIndex("IdCodigoComputos");

                    b.HasIndex("IdHistorialComponente");

                    b.HasIndex("IdMetodoAdquisicion");

                    b.ToTable("components", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.ComponentesHistoriale", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Detalle")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("detalle");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("fecha");

                    b.HasKey("Id")
                        .HasName("PK__componen__3213E83F6DA4C85E");

                    b.ToTable("componentes_historiales", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.MetodosAdquisicion", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("fecha");

                    b.Property<int?>("IdCajaChica")
                        .HasColumnType("int")
                        .HasColumnName("id_caja_chica");

                    b.Property<int?>("IdPedido")
                        .HasColumnType("int")
                        .HasColumnName("id_pedido");

                    b.Property<string>("Otro")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("otro");

                    b.HasKey("Id")
                        .HasName("PK__metodos___3213E83F73343094");

                    b.HasIndex("IdCajaChica");

                    b.HasIndex("IdPedido");

                    b.ToTable("metodos_adquisicion", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Pc", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<int?>("IdComponent")
                        .HasColumnType("int")
                        .HasColumnName("id_component");

                    b.Property<int?>("IdPcHistorial")
                        .HasColumnType("int")
                        .HasColumnName("id_pc_historial");

                    b.Property<int?>("IdPcNombres")
                        .HasColumnType("int")
                        .HasColumnName("id_pc_nombres");

                    b.Property<int?>("IdServices")
                        .HasColumnType("int")
                        .HasColumnName("id_services");

                    b.HasKey("Id")
                        .HasName("PK__pc__3213E83F22923F91");

                    b.HasIndex("IdComponent");

                    b.HasIndex("IdPcHistorial");

                    b.HasIndex("IdPcNombres");

                    b.HasIndex("IdServices");

                    b.ToTable("pc", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.PcHistoriale", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Detalle")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("detalle");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("fecha");

                    b.Property<int?>("IdUser")
                        .HasColumnType("int")
                        .HasColumnName("id_user");

                    b.HasKey("Id")
                        .HasName("PK__pc_histo__3213E83FF50BDB41");

                    b.HasIndex("IdUser");

                    b.ToTable("pc_historiales", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.PcNombre", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Ip")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("ip");

                    b.Property<string>("UserPc")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("user_pc");

                    b.HasKey("Id")
                        .HasName("PK__pc_nombr__3213E83F92C1D106");

                    b.ToTable("pc_nombres", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Detalle")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("detalle");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date")
                        .HasColumnName("fecha");

                    b.Property<int?>("IdProveedor")
                        .HasColumnType("int")
                        .HasColumnName("id_proveedor");

                    b.Property<string>("NumOp")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("num_op");

                    b.Property<string>("NumPedido")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("num_pedido");

                    b.HasKey("Id")
                        .HasName("PK__pedidos__3213E83F7F97B2DC");

                    b.HasIndex("IdProveedor");

                    b.ToTable("pedidos", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Proveedore", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Contacto")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("contacto");

                    b.Property<string>("Historial")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("historial");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PK__proveedo__3213E83F317BB2AD");

                    b.ToTable("proveedores", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Servicio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Service__3214EC071A192842");

                    b.ToTable("servicios", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Toner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Toner__3214EC07D20D831B");

                    b.ToTable("toners", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Rol")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK__Users__3214EC07BD8804B0");

                    b.HasIndex(new[] { "Username" }, "UQ__Users__536C85E487E76B5B")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("PatrimonioAPI.Models.CajaChica", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.Proveedore", "IdProveedorNavigation")
                        .WithMany("CajaChicas")
                        .HasForeignKey("IdProveedor")
                        .HasConstraintName("FK_caja_chica_proveedor");

                    b.Navigation("IdProveedorNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Carga", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.Servicio", "IdServiceNavigation")
                        .WithMany("Cargas")
                        .HasForeignKey("IdService")
                        .HasConstraintName("FK__Carga__IdService__3F466844");

                    b.HasOne("PatrimonioAPI.Models.Toner", "IdTonerNavigation")
                        .WithMany("Cargas")
                        .HasForeignKey("IdToner")
                        .HasConstraintName("FK__Carga__IdToner__403A8C7D");

                    b.HasOne("PatrimonioAPI.Models.User", "IdUsuarioNavigation")
                        .WithMany("Cargas")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__Carga__IdUsuario__3E52440B");

                    b.Navigation("IdServiceNavigation");

                    b.Navigation("IdTonerNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Component", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.Articulo", "IdArticulosNavigation")
                        .WithMany("Components")
                        .HasForeignKey("IdArticulos")
                        .HasConstraintName("FK_components_articulos");

                    b.HasOne("PatrimonioAPI.Models.CodigoComputo", "IdCodigoComputosNavigation")
                        .WithMany("Components")
                        .HasForeignKey("IdCodigoComputos")
                        .HasConstraintName("FK_components_codigo_computos");

                    b.HasOne("PatrimonioAPI.Models.ComponentesHistoriale", "IdHistorialComponenteNavigation")
                        .WithMany("Components")
                        .HasForeignKey("IdHistorialComponente")
                        .HasConstraintName("FK_components_historial_componente");

                    b.HasOne("PatrimonioAPI.Models.MetodosAdquisicion", "IdMetodoAdquisicionNavigation")
                        .WithMany("Components")
                        .HasForeignKey("IdMetodoAdquisicion")
                        .HasConstraintName("FK_components_metodo_adquisicion");

                    b.Navigation("IdArticulosNavigation");

                    b.Navigation("IdCodigoComputosNavigation");

                    b.Navigation("IdHistorialComponenteNavigation");

                    b.Navigation("IdMetodoAdquisicionNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.MetodosAdquisicion", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.CajaChica", "IdCajaChicaNavigation")
                        .WithMany("MetodosAdquisicions")
                        .HasForeignKey("IdCajaChica")
                        .HasConstraintName("FK_metodos_adquisicion_caja_chica");

                    b.HasOne("PatrimonioAPI.Models.Pedido", "IdPedidoNavigation")
                        .WithMany("MetodosAdquisicions")
                        .HasForeignKey("IdPedido")
                        .HasConstraintName("FK_metodos_adquisicion_pedido");

                    b.Navigation("IdCajaChicaNavigation");

                    b.Navigation("IdPedidoNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Pc", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.Component", "IdComponentNavigation")
                        .WithMany("Pcs")
                        .HasForeignKey("IdComponent")
                        .HasConstraintName("FK_pc_components");

                    b.HasOne("PatrimonioAPI.Models.PcHistoriale", "IdPcHistorialNavigation")
                        .WithMany("Pcs")
                        .HasForeignKey("IdPcHistorial")
                        .HasConstraintName("FK_pc_pc_historial");

                    b.HasOne("PatrimonioAPI.Models.PcNombre", "IdPcNombresNavigation")
                        .WithMany("Pcs")
                        .HasForeignKey("IdPcNombres")
                        .HasConstraintName("FK_pc_pc_nombres");

                    b.HasOne("PatrimonioAPI.Models.Servicio", "IdServicesNavigation")
                        .WithMany("Pcs")
                        .HasForeignKey("IdServices")
                        .HasConstraintName("FK_pc_services");

                    b.Navigation("IdComponentNavigation");

                    b.Navigation("IdPcHistorialNavigation");

                    b.Navigation("IdPcNombresNavigation");

                    b.Navigation("IdServicesNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.PcHistoriale", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.User", "IdUserNavigation")
                        .WithMany("PcHistoriales")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_pc_historiales_user");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Pedido", b =>
                {
                    b.HasOne("PatrimonioAPI.Models.Proveedore", "IdProveedorNavigation")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdProveedor")
                        .HasConstraintName("FK_pedidos_proveedor");

                    b.Navigation("IdProveedorNavigation");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Articulo", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.CajaChica", b =>
                {
                    b.Navigation("MetodosAdquisicions");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.CodigoComputo", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Component", b =>
                {
                    b.Navigation("Pcs");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.ComponentesHistoriale", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.MetodosAdquisicion", b =>
                {
                    b.Navigation("Components");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.PcHistoriale", b =>
                {
                    b.Navigation("Pcs");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.PcNombre", b =>
                {
                    b.Navigation("Pcs");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Pedido", b =>
                {
                    b.Navigation("MetodosAdquisicions");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Proveedore", b =>
                {
                    b.Navigation("CajaChicas");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Servicio", b =>
                {
                    b.Navigation("Cargas");

                    b.Navigation("Pcs");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.Toner", b =>
                {
                    b.Navigation("Cargas");
                });

            modelBuilder.Entity("PatrimonioAPI.Models.User", b =>
                {
                    b.Navigation("Cargas");

                    b.Navigation("PcHistoriales");
                });
#pragma warning restore 612, 618
        }
    }
}
