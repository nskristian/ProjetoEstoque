using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Repository.Contracts
{
    public interface IVendidoRepository : IBaseRepository<Vendido>
    {
        List<Vendido> BuscarPorData(DateTime dataInicio, DateTime dataFim);
    }
}
