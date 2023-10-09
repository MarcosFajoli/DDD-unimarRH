using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class FuncionarioRepositorySqlServer : IFuncionarioRepository
    {
        private readonly SqlContext _context;

        public FuncionarioRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Funcionario GetFuncionarioById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> GetFuncionarios()
        {
            throw new NotImplementedException();
        }

        public void InsertFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
