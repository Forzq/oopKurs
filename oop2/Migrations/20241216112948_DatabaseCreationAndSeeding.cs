using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace oop2.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseCreationAndSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contactInfo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    specialization = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Master", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Master_MasterId",
                        column: x => x.MasterId,
                        principalTable: "Master",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EquipmentService",
                columns: table => new
                {
                    EquipmentId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentService", x => new { x.EquipmentId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_EquipmentService_Equipment_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Equipment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentService_Service_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Jesus228", "+375445566333" },
                    { 2, "Mr.P", "+375447300486" },
                    { 3, "Ms. A", "+375447300487" },
                    { 4, "Mr. B", "+375447300488" },
                    { 5, "Mrs. C", "+375447300489" }
                });

            migrationBuilder.InsertData(
                table: "Master",
                columns: new[] { "Id", "Name", "contactInfo", "specialization" },
                values: new object[,]
                {
                    { 1, "Dyadya", "dyadya@gmail.com", "screen fixer" },
                    { 2, "Vanya", "vanya@gmail.com", "laptop repair" },
                    { 3, "Sasha", "sasha@gmail.com", "printer technician" },
                    { 4, "Misha", "misha@gmail.com", "network specialist" },
                    { 5, "Katya", "katya@gmail.com", "mobile device repair" }
                });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Читска оборудования", 10 },
                    { 2, "Ремонт экрана", 25 },
                    { 3, "Настройка сети", 15 },
                    { 4, "Установка программного обеспечения", 20 },
                    { 5, "Обслуживание принтера", 30 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "ClientId", "MasterId", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, "Выполнен" },
                    { 2, 2, 2, "Выполнен" },
                    { 3, 3, 3, "В процессе" },
                    { 4, 4, 4, "Отменен" },
                    { 5, 5, 5, "Выполнен" }
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "Description", "Name", "OrderId" },
                values: new object[,]
                {
                    { 1, "Screen broken", "LG l345", 1 },
                    { 2, "Projector malfunction", "Epson 123", 1 },
                    { 3, "Whiteboard damage", "Standard Whiteboard", 1 },
                    { 4, "Laptop issue", "Dell XPS 15", 1 },
                    { 5, "Microphone not working", "Shure SM58", 1 }
                });

            migrationBuilder.InsertData(
                table: "EquipmentService",
                columns: new[] { "EquipmentId", "ServiceId", "count" },
                values: new object[,]
                {
                    { 2, 1, 1 },
                    { 3, 2, 2 },
                    { 4, 1, 1 },
                    { 5, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_OrderId",
                table: "Equipment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentService_ServiceId",
                table: "EquipmentService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientId",
                table: "Order",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_MasterId",
                table: "Order",
                column: "MasterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentService");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Master");
        }
    }
}
