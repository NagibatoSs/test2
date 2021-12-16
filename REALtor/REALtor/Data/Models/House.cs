using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace REALtor.Data.Models
{
    public class House
    {
        [Keyless]
        [NotMapped]
        public class Conditions
        {
            public bool coldWater;
            public bool hotWater;
            public bool electricity;
            public bool gas;
        }
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? CountOfRooms { get; set; }
        public string Img { get; set; }
        public ulong? Price { get; set; }
        //район
        public string Area { get; set; }
        //новстройка, хрущевка, застройка...
        public string StatusOfHome { get; set; }
        //условия жизни (вода, газ и тд)
        public Conditions Condition { get; set; }
        //Площадь
        public double? Square { get; set; }
        public string Despription { get; set; }
        public bool Available { get; set; }

        public Person Seller { get; set; }

    }
}
