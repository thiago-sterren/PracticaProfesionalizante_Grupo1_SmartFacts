using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class mgmg5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clients_idClienteclienteId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "idClienteclienteId",
                table: "Pedidos",
                newName: "id_clienteidCliente");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_idClienteclienteId",
                table: "Pedidos",
                newName: "IX_Pedidos_id_clienteidCliente");

            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Clients",
                newName: "idCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clients_id_clienteidCliente",
                table: "Pedidos",
                column: "id_clienteidCliente",
                principalTable: "Clients",
                principalColumn: "idCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clients_id_clienteidCliente",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "id_clienteidCliente",
                table: "Pedidos",
                newName: "idClienteclienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Pedidos_id_clienteidCliente",
                table: "Pedidos",
                newName: "IX_Pedidos_idClienteclienteId");

            migrationBuilder.RenameColumn(
                name: "idCliente",
                table: "Clients",
                newName: "clienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clients_idClienteclienteId",
                table: "Pedidos",
                column: "idClienteclienteId",
                principalTable: "Clients",
                principalColumn: "clienteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
