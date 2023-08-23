using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace Exo.WebApi.Contexts
{
    public class ExoContext : DbContext
    {
        public ExoContext()
        {
        }
        public ExoContext(DbContextOptions<ExoContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {

                //Essa String de conexão depende de SUA máquina
               optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;"+"Database=ExoApi;Trusted_Connection=True;");

                //    "User ID=sa;Password=1234;" +
                //    "Server=localhost\\SQLEXPRESS;" +
                //    "Database=vendas;" +
                //    "Trusted_Connection=False;"
                //    );
                //Exemplo 1 de string de conexão:
                //User ID=sa;Password=1234;Server=localhost\\SQLEXPRESS;Database=ExoApi;-
                //+ Trusted_Connection=False;

                //Exemplo 2 de String de conexão
                //Server=localhost\\SQLEXPRESS;Database=ExoApi;Trusted_Connection=True;
            }
        }
        public DbSet<Projeto> Projetos { get; set; }
    }
}