using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Contracts
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        Produto GetByName(string nome);
        List<Produto> GetByNameLike(string nome);
    }
}
