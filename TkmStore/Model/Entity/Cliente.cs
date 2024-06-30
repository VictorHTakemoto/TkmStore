using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkmStore.DAL.Model.Entity
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }
        public string EmailCliente { get; set; }
        public DateTime DataCadastroCliente { get; set; }

        public ICollection<Venda> Vendas { get; set; }
    }
}
