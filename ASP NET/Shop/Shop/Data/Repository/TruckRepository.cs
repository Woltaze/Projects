using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Shop.Data.Repository
{
    public class TruckRepository : IAllTrucks
    {

        private readonly AppDBContent appDBContent;

        public TruckRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }



        public IEnumerable<Truck> Trucks => appDBContent.Truck.Include(c => c.Category);

        public IEnumerable<Truck> getFavTrucks => appDBContent.Truck.Where(p => p.isFavourite).Include(c => c.Category);

        public Truck getObjectTruck(int truckId) => appDBContent.Truck.FirstOrDefault(p => p.id == truckId );

    }
}
