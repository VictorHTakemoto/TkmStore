using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkmStore.DAL.Model.Entity
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescricaoProduto { get; set; }
        public Decimal PrecoProduto { get; set; }
        public int EstoqueProduto { get; set; }
        public DateTime DataCadastroProduto { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
