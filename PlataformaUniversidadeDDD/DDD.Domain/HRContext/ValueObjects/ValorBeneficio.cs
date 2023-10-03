using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.HRContext.ValueObjects
{
    public class ValorBeneficio
    {
        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
        public int BeneficioId { get; set; }
        public Beneficio Beneficio { get; set; }
        public decimal Valor { get; set; }
    }
}
