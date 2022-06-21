using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    public partial class AddMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MembershipType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SignUpFee = table.Column<short>(type: "INTEGER", nullable: false),
                    DurationInMonths = table.Column<byte>(type: "INTEGER", nullable: false),
                    DiscountRate = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembershipType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    iD = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    IsSubscribedToNewsletter = table.Column<bool>(type: "INTEGER", nullable: false),
                    MembershipTypeId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    MembershipTypeId = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.iD);
                    table.ForeignKey(
                        name: "FK_Customer_MembershipType_MembershipTypeId1",
                        column: x => x.MembershipTypeId1,
                        principalTable: "MembershipType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_MembershipTypeId1",
                table: "Customer",
                column: "MembershipTypeId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "MembershipType");
        }
    }
}
