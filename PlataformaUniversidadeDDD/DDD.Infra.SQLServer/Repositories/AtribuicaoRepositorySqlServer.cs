using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class AtribuicaoRepositorySqlServer : IAtribuicaoRepository
    {
        private readonly SqlContext _context;

        public AtribuicaoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteAtribuicao(Atribuicao atribuicao
 )
        {
            try
            {
                _context.Set<Atribuicao>().Remove(atribuicao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Atribuicao> GetAtribuicoes()
        {
            return _context.Atribuicoes.ToList();
        }

        public Atribuicao GetAtribuicaoById(int id)
        {
            return _context.Atribuicoes.Find(id);
        }

        public void InsertAtribuicao(Atribuicao atribuicao)
        {
            try
            {
                _context.Atribuicoes.Add(atribuicao);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateAtribuicao(Atribuicao atribuicao)
        {
            try
            {
                _context.Entry(atribuicao).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
