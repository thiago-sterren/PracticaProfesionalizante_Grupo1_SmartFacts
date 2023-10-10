using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class migg1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CelusNuevos");

            migrationBuilder.DropTable(
                name: "CelusUsados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notebooks",
                table: "Notebooks");

            migrationBuilder.RenameTable(
                name: "Notebooks",
                newName: "Producto");

            migrationBuilder.AlterColumn<string>(
                name: "idioma_teclado",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "cm_ancho",
                table: "Producto",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "cm_alto",
                table: "Producto",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "condicion_bat",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "detalles",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "garantia",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uso",
                table: "Producto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producto",
                table: "Producto",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_pedido = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cantidad_productos = table.Column<int>(type: "int", nullable: false),
                    id_cliente_pedidoid = table.Column<int>(type: "int", nullable: false),
                    id_producto_pedidoid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_id_cliente_pedidoid",
                        column: x => x.id_cliente_pedidoid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Producto_id_producto_pedidoid",
                        column: x => x.id_producto_pedidoid,
                        principalTable: "Producto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_cliente_pedidoid",
                table: "Pedidos",
                column: "id_cliente_pedidoid");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedidoid",
                table: "Pedidos",
                column: "id_producto_pedidoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producto",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "condicion_bat",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "detalles",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "garantia",
                table: "Producto");

            migrationBuilder.DropColumn(
                name: "uso",
                table: "Producto");

            migrationBuilder.RenameTable(
                name: "Producto",
                newName: "Notebooks");

            migrationBuilder.AlterColumn<string>(
                name: "idioma_teclado",
                table: "Notebooks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "cm_ancho",
                table: "Notebooks",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "cm_alto",
                table: "Notebooks",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notebooks",
                table: "Notebooks",
                column: "id");

            migrationBuilder.CreateTable(
                name: "CelusNuevos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    almacenamiento = table.Column<double>(type: "float", nullable: false),
                    disponibilidad = table.Column<int>(type: "int", nullable: false),
                    garantia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    marca_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelusNuevos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CelusUsados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    almacenamiento = table.Column<double>(type: "float", nullable: false),
                    condicion_bat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    detalles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    disponibilidad = table.Column<int>(type: "int", nullable: false),
                    marca_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nombre_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    uso = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelusUsados", x => x.id);
                });
        }
    }
}
