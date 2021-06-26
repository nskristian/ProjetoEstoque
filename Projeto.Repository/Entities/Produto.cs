using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nome, double preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
        }
    }
}
