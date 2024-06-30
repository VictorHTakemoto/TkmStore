using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TkmStore.DAL.Model;
using TkmStore.DAL.Model.Entity;

namespace TkmStore.UI.Controller
{
    public class UserManager
    {
        //Arquivo de funcoes CRUD
        //Esse arquivo contempla as funcoes que tem acesso ao banco de dados
        Cliente cliente = new Cliente();
        //Realizar novo cadastro
        public string NovoCadastro(string nome, string endereco, string telefone, string email)
        {
            using(TkmDBContext db = new TkmDBContext())
            {
                try
                {
                    if (db.Clientes.Any(c => c.NomeCliente == nome || c.EnderecoCliente == endereco || c.TelefoneCliente == telefone || c.EmailCliente == email))
                    {
                        return "Cliente já cadastrado";
                    }
                    cliente.NomeCliente = nome;
                    cliente.EnderecoCliente = endereco;
                    cliente.TelefoneCliente = telefone;
                    cliente.EmailCliente = email;
                    cliente.DataCadastroCliente = DateTime.Now.ToUniversalTime();
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                    return "Cadastro concluido";
                }
                catch (Exception ex)
                {
                    return $"Não foi possivel realizar o cadastro: {ex}";
                }
            }
        }

        //Buscar cadastro
        public List<Cliente> BuscarCadastro()
        {
            using (TkmDBContext db = new TkmDBContext())
            {
                return db.Clientes.ToList();
            }
        }

        //Atualizar cadastro
        public string UpdateCadastro(Cliente cliente)
        {
            try
            {
                using (TkmDBContext db = new TkmDBContext())
                {
                    if (cliente != null) 
                    {
                        db.Entry(cliente).State = EntityState.Modified;
                        db.SaveChanges();
                        return "Produto atualizado com sucesso";
                    }
                    else
                    {
                        return "Problema ao atualizar valores";
                    }
                }
            }
            catch (Exception ex)
            {

                return $"Não foi possivel atualizar cadastro: {ex}";
            }
        }

        //Remover cadastro
        public string RemoverCadastro(Cliente cliente)
        {
            try
            {
                using (TkmDBContext db = new TkmDBContext())
                {
                    db.Clientes.Remove(cliente);
                    db.SaveChanges();
                    return "Cadastro Removido";
                }
            }
            catch (Exception ex)
            {
                return $"Não foi possivel remover o cadastro: {ex}";
            }
        }
    }
}
