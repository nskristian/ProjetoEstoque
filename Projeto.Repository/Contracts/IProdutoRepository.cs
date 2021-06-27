using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Contracts
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        List<Produto> BuscarPeloNome(string nome);
    }
}
