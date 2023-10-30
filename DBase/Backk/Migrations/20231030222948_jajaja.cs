using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class jajaja : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_id_cliente_pedidoid",
                table: "Pedidos");

            migrationBuilder.CreateTable(
                name: "PedidoCliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_clienteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_PedidoCliente_Clientes_id_clienteid",
                        column: x => x.id_clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCliente_id_clienteid",
                table: "PedidoCliente",
                column: "id_clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_PedidoCliente_id_cliente_pedidoid",
                table: "Pedidos",
                column: "id_cliente_pedidoid",
                principalTable: "PedidoCliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_PedidoCliente_id_cliente_pedidoid",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "PedidoCliente");

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
