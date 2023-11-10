using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backk.Migrations
{
    /// <inheritdoc />
    public partial class mgmg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "clienteId",
                table: "Pedidos",
                newName: "idClienteclienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_idClienteclienteId",
                table: "Pedidos",
                column: "idClienteclienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clients_idClienteclienteId",
                table: "Pedidos",
                column: "idClienteclienteId",
                principalTable: "Clients",
                principalColumn: "clienteId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clients_idClienteclienteId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_idClienteclienteId",
                table: "Pedidos");

            migrationBuilder.RenameColumn(
                name: "idClienteclienteId",
                table: "Pedidos",
                newName: "clienteId");
        }
    }
}
