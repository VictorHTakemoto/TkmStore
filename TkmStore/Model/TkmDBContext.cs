using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TkmStore.DAL.Model.Entity;

namespace TkmStore.DAL.Model
{
    //Contexto banco de dados
    public partial class TkmDBContext : DbContext
    {
        public TkmDBContext() { }
        public TkmDBContext
            (DbContextOptions<TkmDBContext> options) : base(options) { }

        //Configuracao de conexao com DB
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Desserialização do arquivo json que contem a string de conexao
            string paramsJson = AppContext.BaseDirectory + "\\params.json";
            JObject globalParams = JObject.Parse(File.ReadAllText(paramsJson));
            try
            {
                if (globalParams["NomeAppSettings"] != null && globalParams["DBConnection"] != null)
                {
                    IConfigurationRoot config = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile(globalParams["NomeAppSettings"].ToString())
                        .Build();
                    if (!optionsBuilder.IsConfigured)
                    {
                        var connectionStr = config.GetConnectionString(globalParams["DBConnection"].ToString());
                        optionsBuilder.UseNpgsql(connectionStr);
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Deu Ruim: " + ex);
            }
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
