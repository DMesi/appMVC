using Microsoft.EntityFrameworkCore.Migrations;

namespace StorageServiceLibrary.Migrations
{
    public partial class Inicialna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategorije",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorije", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_kategorija = table.Column<int>(type: "int", nullable: false),
                    Id_Proizvodjac = table.Column<int>(type: "int", nullable: false),
                    Id_Dobavljac = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Dobavljaci_Id_Dobavljac",
                        column: x => x.Id_Dobavljac,
                        principalTable: "Dobavljaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Kategorije_Id_kategorija",
                        column: x => x.Id_kategorija,
                        principalTable: "Kategorije",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvodi_Proizvodjaci_Id_Proizvodjac",
                        column: x => x.Id_Proizvodjac,
                        principalTable: "Proizvodjaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dobavljaci",
                columns: new[] { "Id", "Adresa", "BrojTelefona", "Naziv" },
                values: new object[,]
                {
                    { 1, "Ime ulice BB", "827352", "ACME" },
                    { 2, "Ime ulice BB", "827352", "GIGATRON" }
                });

            migrationBuilder.InsertData(
                table: "Kategorije",
                columns: new[] { "Id", "Naziv" },
                values: new object[,]
                {
                    { 1, "MONITOR" },
                    { 2, "KUCISTE" },
                    { 3, "LAPTOP" }
                });

            migrationBuilder.InsertData(
                table: "Proizvodjaci",
                columns: new[] { "Id", "Adresa", "BrojTelefona", "Naziv" },
                values: new object[,]
                {
                    { 1, "Ime ulice BB", "123456789", "DELL" },
                    { 2, "Ime ulice BB", "123456789", "ASUS" }
                });

            migrationBuilder.InsertData(
                table: "Proizvodi",
                columns: new[] { "Id", "Cena", "Id_Dobavljac", "Id_Proizvodjac", "Id_kategorija", "Naziv", "Opis" },
                values: new object[] { 1, 21999m, 2, 1, 1, "DELL Monitor 24", "EAN:5397184409336 <br/> Dijagonala:23.8'' <br/>Tip panela:IPS <br/>Rezolucija:1920 x 1080 Full HD <br/>Vreme odziva:4ms <br/>Odnos stranica:16 : 9 <br/>Osvežavanje:75Hz ..." });

            migrationBuilder.InsertData(
                table: "Proizvodi",
                columns: new[] { "Id", "Cena", "Id_Dobavljac", "Id_Proizvodjac", "Id_kategorija", "Naziv", "Opis" },
                values: new object[] { 3, 159999m, 1, 1, 3, "DELL Vostro5625 - NOT19638", "EAN:5290322196382 <br/>Model procesora:AMD Ryzen 7 5825U do 4.5GHz  <br/>Dijagonala ekrana:16''  <br/>Tip grafičke karte:Integrisana Radeon™ RX Vega 8  <br/>RAM (memorija):16GB  <br/>HDD SSD:512GB SSD" });

            migrationBuilder.InsertData(
                table: "Proizvodi",
                columns: new[] { "Id", "Cena", "Id_Dobavljac", "Id_Proizvodjac", "Id_kategorija", "Naziv", "Opis" },
                values: new object[] { 2, 20999m, 2, 2, 2, "ASUS Kućište ROG Z11", "EAN:4718017759526 <br/>Tip:Mini Tower <br/>Kompatibilnost:Mini-ITX, Mini-DTX <br/>Napajanje:Bez napajanja <br/>Boja:Crna" });

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_Id_Dobavljac",
                table: "Proizvodi",
                column: "Id_Dobavljac");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_Id_kategorija",
                table: "Proizvodi",
                column: "Id_kategorija");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvodi_Id_Proizvodjac",
                table: "Proizvodi",
                column: "Id_Proizvodjac");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvodi");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "Kategorije");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");
        }
    }
}
