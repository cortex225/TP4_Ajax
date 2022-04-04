using Microsoft.EntityFrameworkCore.Migrations;

namespace TP4_Ajax.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abonnements",
                columns: table => new
                {
                    AbonnementId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrixMensuel = table.Column<float>(type: "real", nullable: false),
                    RabaisPourcentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonnements", x => x.AbonnementId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Courriel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AbonnementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Clients_Abonnements_AbonnementId",
                        column: x => x.AbonnementId,
                        principalTable: "Abonnements",
                        principalColumn: "AbonnementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abonnements",
                columns: new[] { "AbonnementId", "PrixMensuel", "RabaisPourcentage", "Type" },
                values: new object[] { 1, 0f, 0, "Regulier" });

            migrationBuilder.InsertData(
                table: "Abonnements",
                columns: new[] { "AbonnementId", "PrixMensuel", "RabaisPourcentage", "Type" },
                values: new object[] { 2, 50f, 10, "Argent" });

            migrationBuilder.InsertData(
                table: "Abonnements",
                columns: new[] { "AbonnementId", "PrixMensuel", "RabaisPourcentage", "Type" },
                values: new object[] { 3, 100f, 15, "Or" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AbonnementId",
                table: "Clients",
                column: "AbonnementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Abonnements");
        }
    }
}
