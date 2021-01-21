using DapperApp.Domain;
using DapperApp.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace DapperApp.Data.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        protected readonly string connectionString;

        public AutorRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;
        }

        public bool Create(Autor entidade)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAll()
        {

            using (var cnn = new SqlConnection(connectionString))
            {
                return cnn.Query<Autor>("select * from Autor");
            }

        }

        public bool Update(Autor entidade)
        {
            throw new NotImplementedException();
        }
    }
}