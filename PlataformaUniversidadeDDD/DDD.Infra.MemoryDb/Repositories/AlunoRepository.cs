using DDD.Domain;
using DDD.Infra.MemoryDb.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.MemoryDb.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {

        public AlunoRepository()
        {
            using (var context = new ApiContext())
            {
                var alunos = new List<Aluno>
                {
                new Aluno
                {
                    Nome ="Asdrubal",
                    Sobrenome ="Implementor",
                       Disciplinas = new List<Disciplina>()
                    {
                        new Disciplina { Nome = "Mastering C#"},
                        new Disciplina { Nome = "Entity Framework Tutorial"},
                        new Disciplina { Nome = "Programming is nice"}
                    }
                },
                new Aluno
                {
                    Nome ="Jao",
                    Sobrenome ="das neves",
                    Disciplinas = new List<Disciplina>()
                    {
                        new Disciplina { Nome = "Bora de C#"},
                        new Disciplina { Nome = "Bora de C++"},
                        new Disciplina { Nome = "Bora de Java :("}
                    }
                }
                };
                context.Alunos.AddRange(alunos);
                context.SaveChanges();
            }
        }

        public List<Aluno> GetAlunos()
        {
            using (var context = new ApiContext())
            {
                var list = context.Alunos.Include(x => x.Disciplinas).ToList();
                return list;
            }
        }
    }
}
