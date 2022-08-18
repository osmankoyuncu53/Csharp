using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoGallery.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    admin_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    admin_userName = table.Column<string>(nullable: true),
                    admin_mail = table.Column<string>(nullable: true),
                    admin_password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.admin_id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    car_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    car_plakaNumber = table.Column<string>(nullable: true),
                    car_brand = table.Column<string>(nullable: true),
                    car_model = table.Column<string>(nullable: true),
                    car_year = table.Column<string>(nullable: true),
                    car_fuel = table.Column<string>(nullable: true),
                    car_gear = table.Column<string>(nullable: true),
                    car_km = table.Column<string>(nullable: true),
                    car_driverLicense = table.Column<string>(nullable: true),
                    car_traction = table.Column<string>(nullable: true),
                    car_door = table.Column<string>(nullable: true),
                    car_color = table.Column<string>(nullable: true),
                    car_damage = table.Column<string>(nullable: true),
                    car_money = table.Column<string>(nullable: true),
                    car_image = table.Column<string>(nullable: true),
                    car_info = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.car_id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    customer_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_tcNo = table.Column<string>(nullable: true),
                    customer_name = table.Column<string>(nullable: true),
                    customer_surname = table.Column<string>(nullable: true),
                    customer_dateOfBirth = table.Column<string>(nullable: true),
                    customer_job = table.Column<string>(nullable: true),
                    customer_phoneNumber = table.Column<string>(nullable: true),
                    customer_email = table.Column<string>(nullable: true),
                    customer_adress = table.Column<string>(nullable: true),
                    customer_driverLicense = table.Column<string>(nullable: true),
                    customer_licenseType = table.Column<string>(nullable: true),
                    customer_note = table.Column<string>(nullable: true),
                    customer_image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.customer_id);
                });

            migrationBuilder.CreateTable(
                name: "rentACars",
                columns: table => new
                {
                    rentACar_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rent_purchaseDate = table.Column<DateTime>(nullable: false),
                    rent_deliveryDate = table.Column<DateTime>(nullable: false),
                    rent_totalMoney = table.Column<float>(nullable: false),
                    car_id = table.Column<int>(nullable: false),
                    customer_id = table.Column<int>(nullable: false),
                    Carscar_id = table.Column<int>(nullable: true),
                    Customerscustomer_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rentACars", x => x.rentACar_id);
                    table.ForeignKey(
                        name: "FK_rentACars_Cars_Carscar_id",
                        column: x => x.Carscar_id,
                        principalTable: "Cars",
                        principalColumn: "car_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rentACars_Customers_Customerscustomer_id",
                        column: x => x.Customerscustomer_id,
                        principalTable: "Customers",
                        principalColumn: "customer_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rentACars_Carscar_id",
                table: "rentACars",
                column: "Carscar_id");

            migrationBuilder.CreateIndex(
                name: "IX_rentACars_Customerscustomer_id",
                table: "rentACars",
                column: "Customerscustomer_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "rentACars");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
