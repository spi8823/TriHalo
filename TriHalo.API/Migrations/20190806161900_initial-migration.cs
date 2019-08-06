using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TriHalo.API.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Text",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Original = table.Column<string>(nullable: true),
                    Ruby = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Text", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TitleID = table.Column<int>(nullable: true),
                    ReferenceURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Book_Text_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Text",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParentID = table.Column<int>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    TitleID = table.Column<int>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Chapter_Text_TitleID",
                        column: x => x.TitleID,
                        principalTable: "Text",
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
                    TextID = table.Column<int>(nullable: true)
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
                    table.ForeignKey(
                        name: "FK_Sentence_Text_TextID",
                        column: x => x.TextID,
                        principalTable: "Text",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_TitleID",
                table: "Book",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_ParentID",
                table: "Chapter",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_TitleID",
                table: "Chapter",
                column: "TitleID");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_ParentID",
                table: "Sentence",
                column: "ParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sentence_TextID",
                table: "Sentence",
                column: "TextID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sentence");

            migrationBuilder.DropTable(
                name: "Chapter");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Text");
        }
    }
}
