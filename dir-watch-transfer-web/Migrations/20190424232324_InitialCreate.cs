using Microsoft.EntityFrameworkCore.Migrations;

namespace dirwatchtransferweb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SymbolicLink",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Target = table.Column<string>(nullable: true),
                    Recursive = table.Column<bool>(nullable: false),
                    WatchFileName = table.Column<bool>(nullable: false),
                    WatchDirectoryName = table.Column<bool>(nullable: false),
                    WatchSize = table.Column<bool>(nullable: false),
                    WatchLastWrite = table.Column<bool>(nullable: false),
                    WatchLastAccess = table.Column<bool>(nullable: false),
                    WatchCreationTime = table.Column<bool>(nullable: false),
                    WatchSecurity = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolicLink", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SymbolicLink");
        }
    }
}
