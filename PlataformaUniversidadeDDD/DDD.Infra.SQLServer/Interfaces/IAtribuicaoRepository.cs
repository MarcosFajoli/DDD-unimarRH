using DDD.Domain.HRContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IAtribuicaoRepository
    {
        public List<Atribuicao> GetAtribuicoes();
        public Atribuicao GetAtribuicaoById(int id);
        public void InsertAtribuicao(Atribuicao atribuicao);
        public void UpdateAtribuicao(Atribuicao atribuicao);
        public void DeleteAtribuicao(Atribuicao atribuicao);

    }
}
