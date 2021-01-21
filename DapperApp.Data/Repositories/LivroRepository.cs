using DapperApp.Data.Repositories.Contracts;
using DapperApp.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace DapperApp.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        protected readonly string connectionString;

        public LivroRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;
        }

        public bool Create(Livro entidade)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> GetAll()
        {
            using (var sql = new SqlConnection(connectionString))
            {
                return sql.Query<Livro>("select * from Livro");
            }
        }

        public bool Update(Livro entidade)
        {
            throw new NotImplementedException();
        }
    }
}
