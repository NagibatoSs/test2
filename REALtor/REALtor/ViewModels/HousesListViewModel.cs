using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using REALtor.Data.Models;

namespace REALtor.ViewModels
{
    public class HousesListViewModel
    {
       public IEnumerable<House> allHouses { get; set; }

    }
}
