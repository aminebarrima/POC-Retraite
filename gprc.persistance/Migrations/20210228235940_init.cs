using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GPRC.persistance.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dossier",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_dossier = table.Column<int>(nullable: false),
                    Date_entree_jouissance = table.Column<DateTime>(nullable: false),
                    Date_effet_premier_paiement = table.Column<DateTime>(nullable: false),
                    Num_as400 = table.Column<int>(nullable: false),
                    Zone_libre = table.Column<string>(nullable: true),
                    Flag_majoration_rente = table.Column<bool>(nullable: false),
                    Date_mise_en_sommeil = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dossier", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dossier");
        }
    }
}
