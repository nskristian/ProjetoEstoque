using Dapper;
using Projeto.Repository.Contracts;
using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Projeto.Repository.Repositories
{
    class VendidoRepository : IVendidoRepository
    {
        private readonly string connectionString;

        public VendidoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Vendido entity)
        {
            var query = "insert into Vendido(IdProduto, QuantidadeVendida, DataVenda) "
                      + "values(@IdProduto, @QuantidadeVendida, @DataVenda)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public void Update(Vendido entity)
        {
            var query = "update Vendido set IdProduto = @IdProduto, QuantidadeVendida = @QuantidadeVendida, DataVenda = @DataVenda "
                      + "where IdVendido = @IdVendido";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public void Delete(Vendido entity)
        {
            var query = "delete from Vendido where IdVendido = @IdVendido";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public List<Vendido> GetAll()
        {
            var query = "select * from Vendido Order By Nome Asc";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Vendido>(query).ToList();
            }

        }

        public Vendido GetById(int id)
        {
            var query = "select * from Estoque where IdVendido = @IdVendido";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Vendido>
                    (query, new { IdVendido = id });
            }
        }

        //TODO
        public List<Vendido> BuscarPorData(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }
    }
}
