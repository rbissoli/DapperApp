using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperApp.Domain
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }
        public int CategoriaId { get; set; }

    }
}
