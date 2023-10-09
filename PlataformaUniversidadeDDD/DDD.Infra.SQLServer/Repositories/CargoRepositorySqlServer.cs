using DDD.Domain.HRContext;
using DDD.Infra.SQLServer.Interfaces;
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
            throw new NotImplementedException();
        }

        public List<Cargo> GetCargos()
        {
            throw new NotImplementedException();
        }

        public Cargo GetCargoById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }

        public void UpdateCargo(Cargo cargo)
        {
            throw new NotImplementedException();
        }
    }
}
