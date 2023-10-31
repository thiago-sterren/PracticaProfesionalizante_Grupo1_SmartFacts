using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class mnn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cliente_pedidoid",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_cliente_pedidoid",
                table: "Pedidos",
                column: "cliente_pedidoid");

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

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_cliente_pedidoid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "cliente_pedidoid",
                table: "Pedidos");
        }
    }
}
