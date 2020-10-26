using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Blazor.Data
{
    public class VehicleService
    {
        public ApplicationDbContext _dbContext;

        public VehicleService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public List<Vehicle> GetVehicles()
        {
            return _dbContext.Vehicles.ToList();
        }

        public Vehicle GetVehicleById(int id)
        {
            return _dbContext.Vehicles.FirstOrDefault(x => x.Id.Equals(id));
        }

        public string Create(Vehicle vehicle)
        {
            _dbContext.Vehicles.Add(vehicle);
            _dbContext.SaveChanges();

            return "";
        }

        public string Update(Vehicle vehicle)
        {
            _dbContext.Vehicles.Update(vehicle);
            _dbContext.SaveChanges();

            return "";
        }

        public void Delete(Vehicle vehicle)
        {
            _dbContext.Vehicles.Remove(vehicle);
            _dbContext.SaveChanges();
        }
    }
}
