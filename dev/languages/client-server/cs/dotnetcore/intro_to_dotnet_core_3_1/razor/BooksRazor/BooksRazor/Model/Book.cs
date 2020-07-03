using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksRazor.Model
{
    // Dependencies (packages)
    // -----------------------
    // EFCore
    // EFCore.SqlServer
    // EFCore.Tools (for migrations)

    // To push the model to SQL Server and create the database, perform:
    // Tools\NuGet Package Manager\Package Manager Console
    // PM> add-migration AddBooktoDb
        /* The add-migration CMD creates the following script:
     *
        public partial class AddBooktoDb : Migration
        {
            protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.CreateTable(
                    name: "Book",
                    columns: table => new
                    {
                        Id = table.Column<int>(nullable: false)
                            .Annotation("SqlServer:Identity", "1, 1"),
                        Name = table.Column<string>(nullable: false),
                        Author = table.Column<string>(nullable: true)
                    },
                    constraints: table =>
                    {
                        table.PrimaryKey("PK_Book", x => x.Id);
                    });
            }

            protected override void Down(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.DropTable(
                    name: "Book");
            }
        }
     */
    // PM> update-database (to execute the above script)

    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
