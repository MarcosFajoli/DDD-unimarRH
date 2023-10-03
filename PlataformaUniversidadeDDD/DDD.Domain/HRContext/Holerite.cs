using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.HRContext
{
    public class Holerite
    {
        public int HoleriteId { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataReferente { get; set; }
        public decimal Desconto { get; set; }
        public decimal ValorFinal { get; set; }
    }
}
