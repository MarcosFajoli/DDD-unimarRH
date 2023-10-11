using DDD.Domain.HRContext;
using DDD.Domain.SecretariaContext;
using DDD.Infra.SQLServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class FuncaoRepositorySqlServer : IFuncaoRepository
    {
        private readonly SqlContext _context;
        public FuncaoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteFuncao(Funcao funcao)
        {
            try
            {
                _context.Set<Funcao>().Remove(funcao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcao GetFuncaoById(int id)
        {
            return _context.Funcoes.Find(id);
        }

        public List<Funcao> GetFuncoes()
        {
            return _context.Funcoes.ToList();
        }

        public Funcao InsertFuncao(int idFuncionario, int idAtribuicao)
        {
            var funcionario = _context.Funcionarios.First(i => i.UserId == idFuncionario);
            var atribuicao = _context.Atribuicoes.First(i => i.AtribuicaoId == idAtribuicao);

            var funcao = new Funcao
            {
                Funcionario = funcionario,
                Atribuicao = atribuicao,
                DataInicio = DateTime.Now
            };

            try
            {
                _context.Add(funcao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException;
                throw msg;
            }

            return funcao;
        }
    }
}
