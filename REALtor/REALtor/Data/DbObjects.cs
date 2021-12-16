using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using REALtor.Data.Models;

namespace REALtor.Data
{
    public class DbObjects
    {
        public static void Initial(DbContent content)
        {
            if (!content.House.Any())
            {
                content.AddRange(
                    new House
                    {
                        Name = "ЖК Капитал",
                        CountOfRooms = 4,
                        Area = "October rayon",
                        Price = 1000000,
                        Address = "ул Карла Маркса д 52",
                        Available = true,
                        Img ="/img/house1.jpg",
                        Square=96,
                        Seller = new Person{id=3,Fio = { Name="James3"} }

                    },
                    new House
                    {
                        Name = "ЖК PrivetMedved",
                        CountOfRooms = 4,
                        Area = "October rayon",
                        Price = 123000,
                        Address = "FELIZ NAMIDA",
                        Available = true,
                        Img ="/img/house2.jpg",
                        Square=12,
                        Seller = new Person { id = 2, Fio = { Name = "James2" } }
                    },
                    new House
                    {
                        Name = "Dom na flower street",
                        CountOfRooms = 2,
                        Area = "October rayon",
                        Price = 1005000,
                        Address = "ул Flower d44",
                        Img="/img/house1.jpg",
                        Available = true,
                        Square=33,
                        Seller = new Person { id = 1, Fio = { Name = "James" } }
                    }
                    ) ;
            }
            content.SaveChanges();
        }
    }
}
