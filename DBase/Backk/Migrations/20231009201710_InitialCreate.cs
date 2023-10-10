using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
