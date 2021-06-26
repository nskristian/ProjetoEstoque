using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Entities
{
    public class Vendido
    {
        public int IdVendido { get; set; }
        public int IdProduto { get; set; }
        public int QuantidadeVendida { get; set; }
        public DateTime DataVenda { get; set; }

        public Vendido()
        {

        }

        public Vendido(int idVendido, int idProduto, int quantidadeVendida, DateTime dataVenda)
        {
            IdVendido = idVendido;
            IdProduto = idProduto;
            QuantidadeVendida = quantidadeVendida;
            DataVenda = dataVenda;
        }

        public Produto Produto { get; set; }
    }
}
