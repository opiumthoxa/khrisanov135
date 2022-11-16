using System.Linq;
using SalonAutosport.Models;

namespace SalonAutosport
{
    public static class DBData
    {
        public static void Initialize(AutosalonsContext context)
        {
            if (!context.Auto.Any())
            {
                context.Auto.AddRange(
                    new Auto
                    {

                        CarBrand = "Audi A5",
                        Company = "Audi",
                        Class = "A5",
                        Price =3500000
                    },
                    new Auto
                    {

                        CarBrand = "Mercedes-Benz E",
                        Company = "Mercedes",
                        Class = "E",
                        Price = 3800000
                    },
                    new Auto
                    {

                        CarBrand = "BMW M5",
                        Company = "BMW",
                        Class = "M5",
                        Price = 1800000
                    },
                     new Auto
                     {

                         CarBrand = "Audi A7",
                         Company = "Audi",
                         Class = "A7",
                         Price = 3000000
                     },
                      new Auto
                      {

                          CarBrand = "BMW X6",
                          Company = "BMW",
                          Class = "X6",
                          Price = 4100000
                      }
                );
                context.SaveChanges();
            }
        }
    }
}