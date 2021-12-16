using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using REALtor.Data.Interfaces;
using REALtor.Data.Models;

namespace REALtor.Data.Repository
{
    public class HouseRepository : IAllHouses
    {
        private readonly DbContent dBContent;
        public HouseRepository(DbContent dbContent)
        {
            this.dBContent = dbContent;
        }
        public IEnumerable<House> Houses => dBContent.House;
        //.Include(h => h.id);
        public IEnumerable<House> GetAvailableHouses => dBContent.House.Where(h => h.Available);
        //.Include(h=>h.id)

        public House getObjectHouse(int houseId) => dBContent.House.FirstOrDefault(h => h.id == houseId);
    }
}
