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
    public class CargoRepositorySqlServer : ICargoRepository
    {
        private readonly SqlContext _context;

        public CargoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeleteCargo(Cargo cargo)
        {
            try
            {
                _context.Set<Cargo>().Remove(cargo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cargo> GetCargos()
        {
            return _context.Cargos.ToList();
        }

        public Cargo GetCargoById(int id)
        {
            return _context.Cargos.Find(id);
        }

        public void InsertCargo(Cargo cargo)
        {
            try
            {
                _context.Cargos.Add(cargo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCargo(Cargo cargo)
        {
            try
            {
                _context.Entry(cargo).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
