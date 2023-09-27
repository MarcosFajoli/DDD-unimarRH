using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.HRContext
{
    public class Funcionario : User
    {
        public DateTime DataAdmissao { get; set; }
        public decimal Salario { get; set; }
        public bool FeriasPendentes { get; set; }
        public int MinutosExtras { get; set; }
    }
}
