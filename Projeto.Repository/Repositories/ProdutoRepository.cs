using Projeto.Repository.Contracts;
using Projeto.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Projeto.Repository.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string connectionString;

        public ProdutoRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Create(Produto entity)
        {
            var query = "insert into Produto(Nome, Preco) "
                      + "values(@Nome, @Preco)";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public void Update(Produto entity)
        {
            var query = "update Produto set Nome = @Nome, Preco = @Preco "
                      + "where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public void Delete(Produto entity)
        {
            var query = "delete from Produto where IdProduto = @Idproduto";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(query, entity);
            }

        }

        public List<Produto> GetAll()
        {
            var query = "select * from Produto Order By Nome Asc";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query).ToList();
            }

        }

        public Produto GetById(int id)
        {
            var query = "select * from Produto where IdProduto = @IdProduto";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.QueryFirstOrDefault<Produto>
                    (query, new { IdProduto = id });
            }
        }

        // TODO
        public List<Produto> BuscarPeloNome(string nome)
        {

            var query = "Select * from Produto where Nome Like '%@nome%' order by nome ASC";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Produto>(query).ToList();
            }

        }
    }
}
