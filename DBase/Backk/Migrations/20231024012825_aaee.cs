using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class aaee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidoProducto_Clientes_id_clienteid",
                table: "PedidoProducto");

            migrationBuilder.DropIndex(
                name: "IX_PedidoProducto_id_clienteid",
                table: "PedidoProducto");

            migrationBuilder.DropColumn(
                name: "id_clienteid",
                table: "PedidoProducto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_clienteid",
                table: "PedidoProducto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoProducto_id_clienteid",
                table: "PedidoProducto",
                column: "id_clienteid");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoProducto_Clientes_id_clienteid",
                table: "PedidoProducto",
                column: "id_clienteid",
                principalTable: "Clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
