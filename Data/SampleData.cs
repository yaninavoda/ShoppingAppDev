using ShoppingAppDev.Models;
using System.Diagnostics;

namespace ShoppingAppDev.Data
{
    public static class SampleData
    {
        public static void Initialize(ShoppingDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
            new Customer{FirstName="Carson",LastName="Alexander",Address="495 Erie Center"},
            new Customer{FirstName="Meredith",LastName="Alonso",Address="83051 Onsgard Plaza"},
            new Customer{FirstName="Arturo",LastName="Anand",Address="740 Thompson Court"},
            new Customer{FirstName="Gytis",LastName="Barzdukas",Address="62152 Farragut Point"},
            new Customer{FirstName="Yan",LastName="Li", Address = "8838 Messerschmidt Terrace"},
            new Customer{FirstName="Peggy",LastName="Justice",Address="7 Northwestern Road"},
            new Customer{FirstName="Laura",LastName="Norman", Address = "6 Lukken Circle"},
            new Customer{FirstName="Nino",LastName="Olivetto",Address="90 Del Mar Way"}
            };
            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }
            context.SaveChanges();

            var products = new Product[]
            {
            new Product{Name="milk",Price=42f},
            new Product{Name="bread",Price=30f},
            new Product{Name="cookie",Price=14.5f},
            new Product{Name="cola",Price=13f},
            new Product{Name="sausage",Price=67.8f},
            new Product{Name="chocolate",Price=39.4f},
            new Product{Name="beef steak",Price=238f}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            var markets = new Supermarket[]
            {
            new Supermarket{Name="Silpo", Address="2 Shelley Point"},
            new Supermarket{Name="Fora",Address="99963 Sutteridge Drive"},
            new Supermarket{Name="Fozzi",Address = "27469 Tomscot Place"},
            new Supermarket{Name="ATB",Address="81603 Commercial Road"},
            new Supermarket{Name="Wellmart", Address="274 Maywood Drive"}
            };
            foreach (Supermarket m in markets)
            {
                context.Supermarkets.Add(m);
            }
            context.SaveChanges();
        }
    }
}

