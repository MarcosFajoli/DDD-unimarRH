using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.HRContext
{
    public class Ferias
    {
        public int FeriasId { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
