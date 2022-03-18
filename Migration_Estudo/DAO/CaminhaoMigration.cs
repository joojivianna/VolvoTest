using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Migration_Estudo.DAO
{
    public partial class CaminhaoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE TABLE CAMINHAO(
                                    ID INT NOT NULL,  
  	                                MODELO VARCHAR(2),
  	                                ANO_FABRICACAO DATETIME,
                                    ANO_MODELO DATETIME)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP TABLE CAMINHAO");
        }
    }
}
