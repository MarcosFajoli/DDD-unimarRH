using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.SecretariaContext
{
    public class Disciplina
    {
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public bool Ead { get; set; }
        //public IList<Matricula>? Matriculas { get; set; }
        public IList<Aluno>? Alunos { get; set; }

    }
}
