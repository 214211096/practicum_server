using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProject.Context.Migrations
{
    /// <inheritdoc />
    public partial class form : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyChildren_MyUsers_ParentId",
                table: "MyChildren");

            migrationBuilder.DropIndex(
                name: "IX_MyChildren_ParentId",
                table: "MyChildren");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "MyChildren",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FirstName",
                table: "MyChildren",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyChildren_ParentId",
                table: "MyChildren",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyChildren_MyUsers_ParentId",
                table: "MyChildren",
                column: "ParentId",
                principalTable: "MyUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
