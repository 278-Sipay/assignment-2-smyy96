using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SipayWebApi.Data.Migrations
{
    public partial class SeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 1', 'Sellen', 100001, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 2', 'Sellen', 100002, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 3', 'Sellen', 100003, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 4', 'Sellen', 100004, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 5', 'Sellen', 100005, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Customer (FirstName, LastName, CustomerNumber, Address, IsActive, InsertDate, InsertUser) VALUES ('Denny 6', 'Sellen', 100006, 'Istanbul', true, '2023-02-02', 'SystemAdmin');");


            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100001, 0, 'Denny 1 Account', '2023-04-04', 'TRY', 500001, true, '2023-07-07', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100002, 0, 'Denny 2 Account', '2023-04-04', 'TRY', 500002, true, '2023-07-07', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100003, 0, 'Denny 3 Account', '2023-04-04', 'TRY', 500003, true, '2023-07-07', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100004, 0, 'Denny 4 Account', '2023-04-04', 'TRY', 500004, true, '2023-07-07', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100005, 0, 'Denny 5 Account', '2023-04-04', 'TRY', 500005, true, '2023-07-07', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Account (CustomerNumber, Balance, Name, OpenDate, CurrencyCode, AccountNumber, IsActive, InsertDate, InsertUser) VALUES (100006, 0, 'Denny 6 Account', '2023-04-04', 'TRY', 500006, true, '2023-07-07', 'SystemAdmin');");


            migrationBuilder.Sql("INSERT INTO Transaction (AccountNumber, CreditAmount, DebitAmount, Description, TransactionDate, ReferenceNumber, InsertDate, InsertUser) VALUES (500001, 100.0, 0.0, 'Credit transaction', '2023-07-21', 'REF123', '2023-07-21', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Transaction (AccountNumber, CreditAmount, DebitAmount, Description, TransactionDate, ReferenceNumber, InsertDate, InsertUser) VALUES (500002, 0.0, 50.0, 'Debit transaction', '2023-07-21', 'REF456', '2023-07-21', 'SystemAdmin');");
            migrationBuilder.Sql("INSERT INTO Transaction (AccountNumber, CreditAmount, DebitAmount, Description, TransactionDate, ReferenceNumber, InsertDate, InsertUser) VALUES (500001, 200.0, 0.0, 'Credit transaction', '2023-07-21', 'REF789', '2023-07-21', 'SystemAdmin');");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
