using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class mn1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_id_cliente_pedidoid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "id_cliente_pedidoid",
                table: "Pedidos",
                newName: "cliente_pedidoid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_id_cliente_pedidoid",
                table: "Pedidos",
                newName: "IX_Pedidos_cliente_pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_cliente_pedidoid",
                table: "Pedidos",
                column: "cliente_pedidoid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_cliente_pedidoid",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "cliente_pedidoid",
                table: "Pedidos",
                newName: "id_cliente_pedidoid");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_cliente_pedidoid",
                table: "Pedidos",
                newName: "IX_Pedidos_id_cliente_pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_id_cliente_pedidoid",
                table: "Pedidos",
                column: "id_cliente_pedidoid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
