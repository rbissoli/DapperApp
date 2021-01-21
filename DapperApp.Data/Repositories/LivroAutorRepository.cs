using DapperApp.Data.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using DapperApp.Domain;

namespace DapperApp.Data.Repositories
{
    public class LivroAutorRepository : ILivroAutorRepository
    {
        protected readonly string connectionString;

        public LivroAutorRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["BookStoreConnectionString"].ConnectionString;
        }

        public bool Create(LivroAutor entidade)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LivroAutor> GetAll()
        {
            using (var cnn = new SqlConnection(connectionString))
            {
                return cnn.Query<LivroAutor>(@"select Autor_Id, Livro_Id, L.Nome as NomeAutor, A.Nome as NomeLivro from LivroAutor LA inner join Livro L 
                                                on LA.Livro_Id = L.Id inner join Autor A on LA.Autor_Id = A.Id");
            }
        }

        public bool Update(LivroAutor entidade)
        {
            throw new NotImplementedException();
        }
    }
}
