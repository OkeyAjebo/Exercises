using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayExercise
{
    public class InventoryManager
    {
        public static IEnumerable<Inventory> FreshInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {
                new Inventory()
                {
                    Id = 1,
                    Name = "IPhone X",
                    Price = 350000,
                    Categories = new List<Category>{ GetCategories()[1]},
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Categories = new List<Category>{ GetCategories()[0],GetCategories()[3] },
                    Price = 6000,
                    EntryDate = DateTime.Now
                },
                new Inventory()
                {
                    Id = 3,
                    Name = "Samsung S8",
                    Price = 225000,
                    Categories = new List<Category>{ GetCategories()[2]},
                },

                 new Inventory()
                {
                     Id = 4,
                    Name = "Surface Book 2",
                    Price = 580000,
                    Categories = new List<Category>{ GetCategories()[3]},
                },
                 new Inventory()
                {
                     Id = 5,
                    Name = "Google Nexus Pro",
                    Price = 198000,
                    Categories = new List<Category>{ GetCategories()[4]},
                },
                 new Inventory()
                {
                     Id = 6,
                    Name = "One Plus Six",
                    Price = 265000,
                    Categories = new List<Category>{ GetCategories()[0]},
                },
                 
            };

            return inventories;

        }
        public static IEnumerable<Inventory> GetInventories()
        {
            List<Inventory> inventories = new List<Inventory>()
            {

                new Inventory()
                {
                    Id = 1,
                    Name = "External Sound Card",
                    Categories = new List<Category>{ GetCategories()[1] , GetCategories()[2] },
                    Price = 8000,
                    EntryDate = DateTime.Now
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Categories = new List<Category>{ GetCategories()[0],GetCategories()[3] },
                    Price = 6000,
                    EntryDate = DateTime.Now
                },

                new Inventory()
                {
                    Id = 2,
                    Name = "Keyboard",
                    Categories = new List<Category>{ GetCategories()[0],GetCategories()[3] },
                    Price = 6000,
                    EntryDate = DateTime.Now
                },

                 new Inventory()
                {
                    Id = 3,
                    Name = "VGA Converter",
                    Categories = new List<Category>{ GetCategories()[0] },
                    Price = 4800,
                    EntryDate = DateTime.Now
                },

                  new Inventory()
                {
                    Id = 4,
                    Name = "Wireless Keyboard",
                    Categories = new List<Category>{ GetCategories()[3] },
                    Price = 2000,
                    EntryDate = DateTime.Now
                },

                   new Inventory()
                {
                    Id = 5,
                    Name = "HMDI Adapter",
                    Categories = new List<Category>{ GetCategories()[4] },
                    Price = 1800,
                    EntryDate = DateTime.Now
                }
            };

            return inventories;

        }

        public static List<Category> GetCategories()
        {
            Category[] categories = new Category[5]
            {
                new Category(){ Name = "Computer Accessorires"},
                 new Category(){ Name = "Laptop"},
                    new Category(){ Name = "Computer Gadget"},
                    new Category(){ Name = "Peripherals"},
                    new Category(){ Name = "Mobile Devices"}
            };

            return categories.ToList();
        }

        
    }
}
