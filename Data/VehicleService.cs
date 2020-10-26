using Microsoft.EntityFrameworkCore;
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

        public List<Vehicle> GetVehicles(OrderBy order, bool isAscending)
        {
            if (isAscending)
            {
                switch (order)
                {
                    case OrderBy.Owner:
                        return _dbContext.Vehicles.AsNoTracking().OrderBy(x => x.Owner).ToList();
                    case OrderBy.Manufacturer:
                        return _dbContext.Vehicles.AsNoTracking().OrderBy(x => x.Manufacturer).ToList();
                    case OrderBy.ManufacturingYear:
                        return _dbContext.Vehicles.AsNoTracking().OrderBy(x => x.ManufacturingYear).ToList();
                    case OrderBy.Weight:
                        return _dbContext.Vehicles.AsNoTracking().OrderBy(x => x.Weight).ToList();
                    default:
                        return _dbContext.Vehicles.AsNoTracking().OrderBy(x => x.Owner).ToList();
                }
            }
            else
            {
                switch (order)
                {
                    case OrderBy.Owner:
                        return _dbContext.Vehicles.AsNoTracking().OrderByDescending(x => x.Owner).ToList();
                    case OrderBy.Manufacturer:
                        return _dbContext.Vehicles.AsNoTracking().OrderByDescending(x => x.Manufacturer).ToList();
                    case OrderBy.ManufacturingYear:
                        return _dbContext.Vehicles.AsNoTracking().OrderByDescending(x => x.ManufacturingYear).ToList();
                    case OrderBy.Weight:
                        return _dbContext.Vehicles.AsNoTracking().OrderByDescending(x => x.Weight).ToList();
                    default:
                        return _dbContext.Vehicles.AsNoTracking().OrderByDescending(x => x.Owner).ToList();
                }
            }
        }

        public Vehicle GetVehicleById(int id)
        {
            return _dbContext.Vehicles.FirstOrDefault(x => x.Id.Equals(id));
        }

        public string Create(Vehicle vehicle)
        {
            if(vehicle.Owner == null || vehicle.ManufacturingYear == null || vehicle.Weight <= 0)
            {
                return "Please fill up the fields carefully.";
            }

            _dbContext.Vehicles.Add(vehicle);
            _dbContext.SaveChanges();

            return "";
        }

        public string Update(Vehicle vehicle)
        {
            if (vehicle.Owner == null || vehicle.ManufacturingYear == null || vehicle.Weight <= 0)
            {
                return "Please fill up the fields carefully.";
            }

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
