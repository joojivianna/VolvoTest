using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Migration_Estudo.Models
{

    public class CaminhaoContext : DbContext
    {
        public DbSet<Caminhao> Caminhoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=.\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        }
    }

    public class Caminhao
    {
        [Key]
        public int ID { get; set; }
        public string Modelo { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public DateTime AnoModelo { get; set; }
    }
}
