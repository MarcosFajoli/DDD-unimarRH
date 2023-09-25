using DDD.Domain.UserManagementContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.SecretariaContext
{
    public class Aluno : User
    {
        public List<Disciplina>? Disciplinas { get; set; }
        //public IList<Matricula>? Matriculas { get; set; }
    }
}
