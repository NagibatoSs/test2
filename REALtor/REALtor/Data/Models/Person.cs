using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace REALtor.Data.Models
{
    public class Person
    {
        [Keyless]
        [NotMapped]
        public class FIO
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string FatherName { get; set; }

            public override string ToString()
            {
                return (Surname + " " + Name + " " + FatherName);
            }
        }
        public int id { get; set; }
        public FIO Fio { get; set; }
        public int? NumberOfPhone { get; set; }
        public string Email { get; set; }
        public string Requirements { get; set; }
        //покупатель или разместитель
        public string Status { get; set; }
    }
}
