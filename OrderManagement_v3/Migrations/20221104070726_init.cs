using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement_v3.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Cust_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(30)", nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", nullable: true),
                    Mobileno = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "varchar(30)", nullable: true),
                    State = table.Column<string>(type: "varchar(30)", nullable: true),
                    City = table.Column<string>(type: "varchar(30)", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(70)", nullable: true),
                    Password = table.Column<string>(type: "varchar(30)", nullable: true),
                    RePassword = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Cust_id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Product_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "varchar(30)", nullable: true),
                    Size = table.Column<string>(type: "varchar(10)", nullable: true),
                    Color = table.Column<string>(type: "varchar(20)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Product_details = table.Column<string>(type: "varchar(70)", nullable: true),
                    ImageUrl = table.Column<string>(type: "varchar(30)", nullable: true),
                    ProductPrice = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Product_id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Order_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_details = table.Column<string>(type: "varchar(70)", nullable: true),
                    Status = table.Column<string>(type: "varchar(20)", nullable: true),
                    Order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shipment_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Delivery_Address = table.Column<string>(type: "varchar(70)", nullable: true),
                    Payment_method = table.Column<string>(type: "varchar(20)", nullable: true),
                    Total_Price = table.Column<int>(type: "int", nullable: false),
                    customerCust_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Order_id);
                    table.ForeignKey(
                        name: "FK_orders_customers_customerCust_id",
                        column: x => x.customerCust_id,
                        principalTable: "customers",
                        principalColumn: "Cust_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    ReferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<string>(type: "varchar(20)", nullable: true),
                    Order_id = table.Column<int>(type: "int", nullable: true),
                    Product_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.ReferenceId);
                    table.ForeignKey(
                        name: "FK_OrderItems_orders_Order_id",
                        column: x => x.Order_id,
                        principalTable: "orders",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_products_Product_id",
                        column: x => x.Product_id,
                        principalTable: "products",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Order_id",
                table: "OrderItems",
                column: "Order_id");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_Product_id",
                table: "OrderItems",
                column: "Product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerCust_id",
                table: "orders",
                column: "customerCust_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
