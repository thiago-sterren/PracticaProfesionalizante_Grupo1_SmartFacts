using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class aa1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clients_id_clienteidCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_id_clienteidCliente",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "id_clienteidCliente",
                table: "Pedidos",
                newName: "clienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Pedidos",
                newName: "id_clienteidCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_id_clienteidCliente",
                table: "Pedidos",
                column: "id_clienteidCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clients_id_clienteidCliente",
                table: "Pedidos",
                column: "id_clienteidCliente",
                principalTable: "Clients",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
