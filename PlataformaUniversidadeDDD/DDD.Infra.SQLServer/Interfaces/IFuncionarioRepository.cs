using DDD.Domain.HRContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IFuncionarioRepository
    {
        public List<Funcionario> GetFuncionarios();
        public Funcionario GetFuncionarioById(int id);
        public void InsertFuncionario(Funcionario funcionario);
        public void UpdateFuncionario(Funcionario funcionario);
        public void DeleteFuncionario(Funcionario funcionario);

    }
}
