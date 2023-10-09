using DDD.Domain.HRContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface ICargoRepository
    {
        public List<Cargo> GetCargos();
        public Cargo GetCargoById(int id);
        public void InsertCargo(Cargo cargo);
        public void UpdateCargo(Cargo cargo);
        public void DeleteCargo(Cargo cargo);

    }
}
