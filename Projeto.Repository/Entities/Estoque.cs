using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Entities
{
    public class Estoque
    {
        public int IdEstoque { get; set; }
        public int IdProduto { get; set; }
        public DateTime DataDeEntrada { get; set; }
        public int Quantidade { get; set; }

        public Estoque()
        {

        }

        public Estoque(int idEstoque, int idProduto, DateTime dataDeEntrada, int quantidade)
        {
            IdEstoque = idEstoque;
            IdProduto = idProduto;
            DataDeEntrada = dataDeEntrada;
            Quantidade = quantidade;
        }

        public List<Produto> Produtos { get; set; }
    }
}