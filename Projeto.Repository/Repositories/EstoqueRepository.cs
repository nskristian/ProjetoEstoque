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
    public class EstoqueRepository : IEstoqueRepository
    {
        private readonly string connectionString;

        public EstoqueRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Estoque entity)
        {
            var query = "insert into Estoque(IdProduto, DataEntrada, Quantidade) "
                      + "values(@Idproduto, @DataEntrada, @Quantidade)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);  
            }

        }

        public void Update(Estoque entity)
        {
            var query = "update Estoque set Idproduto = @IdProduto, DataEntrada = @DataEntrada, Quantidade = @Quantidade "
                      + "where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public void Delete(Estoque entity)
        {
            var query = "delete from Estoque where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public List<Estoque> GetAll()
        {
            var query = "select * from Estoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Estoque>(query).ToList();
            }

        }

        public Estoque GetById(int id)
        {
            var query = "select * from Estoque where IdEstoque = @IdEstoque";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Estoque>
                    (query, new { IdEstoque = id });
            }

        }
    }
}
