using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriHalo.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title_Original = table.Column<string>(nullable: true),
                    Title_Ruby = table.Column<string>(nullable: true),
                    ReferenceURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Title_Original = table.Column<string>(nullable: true),
                    Title_Ruby = table.Column<string>(nullable: true),
                    ReferenceURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chapter_Book_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Book",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sentence",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Text_Original = table.Column<string>(nullable: true),
                    Text_Ruby = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sentence", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sentence_Chapter_ParentID",
                        column: x => x.ParentID,
                        principalTable: "Chapter",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_ParentID",
                table: "Chapter",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_ParentID",
                table: "Sentence",
                column: "ParentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sentence");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
