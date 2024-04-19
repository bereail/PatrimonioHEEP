using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PatrimonioAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "articulos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__articulo__3213E83FCA089286", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "codigo_computos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    codigo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__codigo_c__3213E83FE8848638", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "componentes_historiales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    detalle = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fecha = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__componen__3213E83F6DA4C85E", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pc_nombres",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    ip = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    user_pc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pc_nombr__3213E83F92C1D106", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    contacto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    historial = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__proveedo__3213E83F317BB2AD", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Service__3214EC071A192842", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "toners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Toner__3214EC07D20D831B", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3214EC07BD8804B0", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "caja_chica",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: true),
                    id_proveedor = table.Column<int>(type: "int", nullable: true),
                    monto = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    num_caja = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    pago = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__caja_chi__3213E83F2FED0D43", x => x.id);
                    table.ForeignKey(
                        name: "FK_caja_chica_proveedor",
                        column: x => x.id_proveedor,
                        principalTable: "proveedores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    detalle = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fecha = table.Column<DateTime>(type: "date", nullable: true),
                    id_proveedor = table.Column<int>(type: "int", nullable: true),
                    num_op = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    num_pedido = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pedidos__3213E83F7F97B2DC", x => x.id);
                    table.ForeignKey(
                        name: "FK_pedidos_proveedor",
                        column: x => x.id_proveedor,
                        principalTable: "proveedores",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "cargas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: true),
                    IdService = table.Column<int>(type: "int", nullable: true),
                    IdToner = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Carga__3214EC0767AA9F39", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Carga__IdService__3F466844",
                        column: x => x.IdService,
                        principalTable: "servicios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Carga__IdToner__403A8C7D",
                        column: x => x.IdToner,
                        principalTable: "toners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Carga__IdUsuario__3E52440B",
                        column: x => x.IdUsuario,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "pc_historiales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    detalle = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    fecha = table.Column<DateTime>(type: "date", nullable: true),
                    id_user = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pc_histo__3213E83FF50BDB41", x => x.id);
                    table.ForeignKey(
                        name: "FK_pc_historiales_user",
                        column: x => x.id_user,
                        principalTable: "users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "metodos_adquisicion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateTime>(type: "date", nullable: true),
                    id_caja_chica = table.Column<int>(type: "int", nullable: true),
                    id_pedido = table.Column<int>(type: "int", nullable: true),
                    otro = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__metodos___3213E83F73343094", x => x.id);
                    table.ForeignKey(
                        name: "FK_metodos_adquisicion_caja_chica",
                        column: x => x.id_caja_chica,
                        principalTable: "caja_chica",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_metodos_adquisicion_pedido",
                        column: x => x.id_pedido,
                        principalTable: "pedidos",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "components",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    estado_activo = table.Column<bool>(type: "bit", nullable: true),
                    id_articulos = table.Column<int>(type: "int", nullable: true),
                    id_codigo_computos = table.Column<int>(type: "int", nullable: true),
                    id_historial_componente = table.Column<int>(type: "int", nullable: true),
                    id_metodo_adquisicion = table.Column<int>(type: "int", nullable: true),
                    num_patrimonio = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__componen__3213E83FC627EDAD", x => x.id);
                    table.ForeignKey(
                        name: "FK_components_articulos",
                        column: x => x.id_articulos,
                        principalTable: "articulos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_components_codigo_computos",
                        column: x => x.id_codigo_computos,
                        principalTable: "codigo_computos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_components_historial_componente",
                        column: x => x.id_historial_componente,
                        principalTable: "componentes_historiales",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_components_metodo_adquisicion",
                        column: x => x.id_metodo_adquisicion,
                        principalTable: "metodos_adquisicion",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_component = table.Column<int>(type: "int", nullable: true),
                    id_pc_historial = table.Column<int>(type: "int", nullable: true),
                    id_pc_nombres = table.Column<int>(type: "int", nullable: true),
                    id_services = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__pc__3213E83F22923F91", x => x.id);
                    table.ForeignKey(
                        name: "FK_pc_components",
                        column: x => x.id_component,
                        principalTable: "components",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pc_pc_historial",
                        column: x => x.id_pc_historial,
                        principalTable: "pc_historiales",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pc_pc_nombres",
                        column: x => x.id_pc_nombres,
                        principalTable: "pc_nombres",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_pc_services",
                        column: x => x.id_services,
                        principalTable: "servicios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_caja_chica_id_proveedor",
                table: "caja_chica",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_cargas_IdService",
                table: "cargas",
                column: "IdService");

            migrationBuilder.CreateIndex(
                name: "IX_cargas_IdToner",
                table: "cargas",
                column: "IdToner");

            migrationBuilder.CreateIndex(
                name: "IX_cargas_IdUsuario",
                table: "cargas",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_components_id_articulos",
                table: "components",
                column: "id_articulos");

            migrationBuilder.CreateIndex(
                name: "IX_components_id_codigo_computos",
                table: "components",
                column: "id_codigo_computos");

            migrationBuilder.CreateIndex(
                name: "IX_components_id_historial_componente",
                table: "components",
                column: "id_historial_componente");

            migrationBuilder.CreateIndex(
                name: "IX_components_id_metodo_adquisicion",
                table: "components",
                column: "id_metodo_adquisicion");

            migrationBuilder.CreateIndex(
                name: "IX_metodos_adquisicion_id_caja_chica",
                table: "metodos_adquisicion",
                column: "id_caja_chica");

            migrationBuilder.CreateIndex(
                name: "IX_metodos_adquisicion_id_pedido",
                table: "metodos_adquisicion",
                column: "id_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_pc_id_component",
                table: "pc",
                column: "id_component");

            migrationBuilder.CreateIndex(
                name: "IX_pc_id_pc_historial",
                table: "pc",
                column: "id_pc_historial");

            migrationBuilder.CreateIndex(
                name: "IX_pc_id_pc_nombres",
                table: "pc",
                column: "id_pc_nombres");

            migrationBuilder.CreateIndex(
                name: "IX_pc_id_services",
                table: "pc",
                column: "id_services");

            migrationBuilder.CreateIndex(
                name: "IX_pc_historiales_id_user",
                table: "pc_historiales",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_pedidos_id_proveedor",
                table: "pedidos",
                column: "id_proveedor");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__536C85E487E76B5B",
                table: "users",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cargas");

            migrationBuilder.DropTable(
                name: "pc");

            migrationBuilder.DropTable(
                name: "toners");

            migrationBuilder.DropTable(
                name: "components");

            migrationBuilder.DropTable(
                name: "pc_historiales");

            migrationBuilder.DropTable(
                name: "pc_nombres");

            migrationBuilder.DropTable(
                name: "servicios");

            migrationBuilder.DropTable(
                name: "articulos");

            migrationBuilder.DropTable(
                name: "codigo_computos");

            migrationBuilder.DropTable(
                name: "componentes_historiales");

            migrationBuilder.DropTable(
                name: "metodos_adquisicion");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "caja_chica");

            migrationBuilder.DropTable(
                name: "pedidos");

            migrationBuilder.DropTable(
                name: "proveedores");
        }
    }
}
