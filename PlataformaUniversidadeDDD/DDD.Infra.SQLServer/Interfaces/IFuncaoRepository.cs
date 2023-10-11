using DDD.Domain.HRContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IFuncaoRepository
    {
        public List<Funcao> GetFuncoes();
        public Funcao GetFuncaoById(int id);
        public Funcao InsertFuncao(int idFuncionario, int idAtribuicao);
        public void DeleteFuncao(Funcao funcao);
    }
}
