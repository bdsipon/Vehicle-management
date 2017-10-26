using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Vehiclemanagement.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO MAKES (NAME) VALUES ('MAKE1')");
             migrationBuilder.Sql("INSERT INTO MAKES (NAME) VALUES ('MAKE2')");
              migrationBuilder.Sql("INSERT INTO MAKES (NAME) VALUES ('MAKE3')");

              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make1-ModelA',(SELECT ID FROM Makes WHERE Name='Make1'))");
             migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make1-ModelB',(SELECT ID FROM Makes WHERE Name='Make1'))");
              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make1-ModelC',(SELECT ID FROM Makes WHERE Name='Make1'))");


              
              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make2-ModelA',(SELECT ID FROM Makes WHERE Name='Make2'))");
             migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make2-ModelB',(SELECT ID FROM Makes WHERE Name='Make2'))");
              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make2-ModelC',(SELECT ID FROM Makes WHERE Name='Make2'))");

               
              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make3-ModelA',(SELECT ID FROM Makes WHERE Name='Make3'))");
             migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make3-ModelB',(SELECT ID FROM Makes WHERE Name='Make3'))");
              migrationBuilder.Sql("INSERT INTO Model (Name,MakeId) VALUES('Make3-ModelC',(SELECT ID FROM Makes WHERE Name='Make3'))");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name in('Make1','Make2','Make3')");

        }
    }
}
