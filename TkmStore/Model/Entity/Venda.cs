using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkmStore.DAL.Model.Entity
{
    public class Venda
    {
        [Key]
        public int IdVenda { get; set; }
        public int? IdCliente { get; set; }
        public Cliente Clientes { get; set; }
        public int? IdProduto { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVenda { get; set; }
        public string DescricaoVenda { get; set; }
    }
}
