using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddUserDomain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_RentInvoices_RentInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_SaleInvoices_SaleInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RentInvoices_Customers_CustomerId",
                table: "RentInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RentInvoices_PaymentMethods_PaymentMethodId",
                table: "RentInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_PaymentMethods_PaymentMethodId",
                table: "SaleInvoices");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactInfoId",
                table: "Customers");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "SaleInvoices",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "SaleInvoices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SaleInvoiceNumber",
                table: "SaleInvoices",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "SaleInvoices",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaleInvoices",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "RentInvoices",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "RentInvoices",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RentInvoiceNumber",
                table: "RentInvoices",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "RentInvoices",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RentInvoices",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "InvoiceItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "InvoiceItems",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<decimal>(
                name: "Credit",
                table: "Customers",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactInfos",
                type: "nvarchar(254)",
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<short>(
                name: "YearPublished",
                table: "Books",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightGrams",
                table: "Books",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Books",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18);

            migrationBuilder.AlterColumn<decimal>(
                name: "RentPrice",
                table: "Books",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)",
                oldPrecision: 18,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                type: "nvarchar(17)",
                maxLength: 17,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Edition",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Dimensions",
                table: "Books",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImagePath",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AddByUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_NationalCode",
                table: "Customers",
                column: "NationalCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_RentInvoices_RentInvoiceId",
                table: "InvoiceItems",
                column: "RentInvoiceId",
                principalTable: "RentInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_SaleInvoices_SaleInvoiceId",
                table: "InvoiceItems",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentInvoices_Customers_CustomerId",
                table: "RentInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentInvoices_PaymentMethods_PaymentMethodId",
                table: "RentInvoices",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_PaymentMethods_PaymentMethodId",
                table: "SaleInvoices",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_RentInvoices_RentInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceItems_SaleInvoices_SaleInvoiceId",
                table: "InvoiceItems");

            migrationBuilder.DropForeignKey(
                name: "FK_RentInvoices_Customers_CustomerId",
                table: "RentInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_RentInvoices_PaymentMethods_PaymentMethodId",
                table: "RentInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleInvoices_PaymentMethods_PaymentMethodId",
                table: "SaleInvoices");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Customers_NationalCode",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "SaleInvoices",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "SaleInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "SaleInvoiceNumber",
                table: "SaleInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "SaleInvoices",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SaleInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "RentInvoices",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "SellerName",
                table: "RentInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RentInvoiceNumber",
                table: "RentInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "RentInvoices",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RentInvoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<decimal>(
                name: "UnitPrice",
                table: "InvoiceItems",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPrice",
                table: "InvoiceItems",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Credit",
                table: "Customers",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactInfoId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ContactInfos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(254)",
                oldMaxLength: 254);

            migrationBuilder.AlterColumn<int>(
                name: "YearPublished",
                table: "Books",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<decimal>(
                name: "WeightGrams",
                table: "Books",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "SalePrice",
                table: "Books",
                type: "decimal(18,0)",
                precision: 18,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "RentPrice",
                table: "Books",
                type: "decimal(18,0)",
                precision: 18,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldPrecision: 18,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Isbn",
                table: "Books",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(17)",
                oldMaxLength: 17);

            migrationBuilder.AlterColumn<string>(
                name: "Edition",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Dimensions",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoverImagePath",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_LanguageId",
                table: "Books",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerTypes_CustomerTypeId",
                table: "Customers",
                column: "CustomerTypeId",
                principalTable: "CustomerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_RentInvoices_RentInvoiceId",
                table: "InvoiceItems",
                column: "RentInvoiceId",
                principalTable: "RentInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceItems_SaleInvoices_SaleInvoiceId",
                table: "InvoiceItems",
                column: "SaleInvoiceId",
                principalTable: "SaleInvoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentInvoices_Customers_CustomerId",
                table: "RentInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentInvoices_PaymentMethods_PaymentMethodId",
                table: "RentInvoices",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_Customers_CustomerId",
                table: "SaleInvoices",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleInvoices_PaymentMethods_PaymentMethodId",
                table: "SaleInvoices",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
