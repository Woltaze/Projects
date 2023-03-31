using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
   public interface IAllTrucks
    {
        IEnumerable<Truck> Trucks { get; }
        IEnumerable<Truck> getFavTrucks { get; }
        Truck getObjectTruck(int truckId);
    }
}
