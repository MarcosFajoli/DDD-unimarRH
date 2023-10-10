using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.HRContext
{
    public class Cargo
    {
        public int CargoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public IList<Funcionario>? Funcionarios { get; set; }
    }
}
