using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class ab : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_2id",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_3id",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_4id",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_5id",
                table: "Pedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedidoid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_producto_pedido_2id",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_producto_pedido_3id",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_producto_pedido_4id",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_producto_pedido_5id",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_producto_pedidoid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "id_producto_pedido_2id",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "id_producto_pedido_3id",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "id_producto_pedido_4id",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "id_producto_pedido_5id",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "id_producto_pedidoid",
                table: "Pedidos");

            migrationBuilder.CreateTable(
                name: "PedidoProducto",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_clienteid = table.Column<int>(type: "int", nullable: false),
                    id_productoid = table.Column<int>(type: "int", nullable: false),
                    Pedidoid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoProducto", x => x.id);
                    table.ForeignKey(
                        name: "FK_PedidoProducto_Clientes_id_clienteid",
                        column: x => x.id_clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoProducto_Pedidos_Pedidoid",
                        column: x => x.Pedidoid,
                        principalTable: "Pedidos",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PedidoProducto_Producto_id_productoid",
                        column: x => x.id_productoid,
                        principalTable: "Producto",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProducto_id_clienteid",
                table: "PedidoProducto",
                column: "id_clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProducto_id_productoid",
                table: "PedidoProducto",
                column: "id_productoid");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProducto_Pedidoid",
                table: "PedidoProducto",
                column: "Pedidoid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PedidoProducto");

            migrationBuilder.AddColumn<int>(
                name: "id_producto_pedido_2id",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_producto_pedido_3id",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_producto_pedido_4id",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_producto_pedido_5id",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_producto_pedidoid",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedido_2id",
                table: "Pedidos",
                column: "id_producto_pedido_2id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedido_3id",
                table: "Pedidos",
                column: "id_producto_pedido_3id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedido_4id",
                table: "Pedidos",
                column: "id_producto_pedido_4id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedido_5id",
                table: "Pedidos",
                column: "id_producto_pedido_5id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_producto_pedidoid",
                table: "Pedidos",
                column: "id_producto_pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_2id",
                table: "Pedidos",
                column: "id_producto_pedido_2id",
                principalTable: "Producto",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_3id",
                table: "Pedidos",
                column: "id_producto_pedido_3id",
                principalTable: "Producto",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_4id",
                table: "Pedidos",
                column: "id_producto_pedido_4id",
                principalTable: "Producto",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedido_5id",
                table: "Pedidos",
                column: "id_producto_pedido_5id",
                principalTable: "Producto",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Producto_id_producto_pedidoid",
                table: "Pedidos",
                column: "id_producto_pedidoid",
                principalTable: "Producto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
