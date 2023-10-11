﻿using DDD.Domain.SecretariaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IAlunoRepository
    {
        public List<Aluno> GetAlunos();
        public Aluno GetAlunoById(int id);
        public void InsertAluno(Aluno aluno);
        public void UpdateAluno(Aluno aluno);
        public void DeleteAluno(Aluno aluno);
    }
}