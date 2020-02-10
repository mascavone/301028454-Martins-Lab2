using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301028454_Martins_Lab2
{
    public class Menu
    {
        // Create a List of objects  beverages
        public List<CheckOut> beverages = new List<CheckOut>
        {
            new CheckOut
            {
                ID = 001,
                ItemName = "Soda",
                ItemPrice = 1.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 002,
                ItemName = "Tea",
                ItemPrice = 1.50,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 003,
                ItemName = "Coffee",
                ItemPrice = 1.25,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 004,
                ItemName = "Mineral Water",
                ItemPrice = 2.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 005,
                ItemName = "Juice",
                ItemPrice = 2.50,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 006,
                ItemName = "Milk",
                ItemPrice = 1.50,
                Quantity = 1
            }
        };

        // Create a List of objects appetizers  
        public List<CheckOut> appetizers = new List<CheckOut>
        {
            new CheckOut
            {
            ID = 007,
            ItemName = "Buffalo Wings",
            ItemPrice = 5.95,
            Quantity = 1
            },

            new CheckOut
            {
                ID = 008,
                ItemName = "Buffalo Fingers",
                ItemPrice = 6.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 009,
                ItemName = "Potato Skins",
                ItemPrice = 8.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 010,
                ItemName = "Nachos",
                ItemPrice = 8.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 011,
                ItemName = "Mushroom Caps",
                ItemPrice = 10.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 012,
                ItemName = "Shrimp Cocktail",
                ItemPrice = 12.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 013,
                ItemName = "Chips and Salsa",
                ItemPrice = 6.95,
                Quantity = 1
            }
        };

        // Create a List of objects Main Course  
        public List<CheckOut> mainCourse = new List<CheckOut>
        {
            new CheckOut
            {
                ID = 014,
                ItemName = "Seafood Alfredo",
                ItemPrice = 15.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 015,
                ItemName = "Chicken Alfredo",
                ItemPrice = 13.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 015,
                ItemName = "Chicken Picatta",
                ItemPrice = 13.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 016,
                ItemName = "Turkey Club",
                ItemPrice = 11.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 017,
                ItemName = "Lobster Pie",
                ItemPrice = 19.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 018,
                ItemName = "Prime Rib",
                ItemPrice = 20.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 019,
                ItemName = "Shrimp Scampi",
                ItemPrice = 18.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 020,
                ItemName = "Turkey Dinner",
                ItemPrice = 13.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 021,
                ItemName = "Stuffed Chicken",
                ItemPrice = 14.95,
                Quantity = 1
            }
        };

        // Create a List of objects desserts
        public List<CheckOut> desserts = new List<CheckOut>
        {
            new CheckOut
            {
                ID = 022,
                ItemName = "Apple Pie",
                ItemPrice = 5.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 023,
                ItemName = "Sundae",
                ItemPrice = 3.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 024,
                ItemName = "Carrot Cake",
                ItemPrice = 5.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 025,
                ItemName = "Mud Pie",
                ItemPrice = 4.95,
                Quantity = 1
            },

            new CheckOut
            {
                ID = 026,
                ItemName = "Apple Crisp",
                ItemPrice = 4.95,
                Quantity = 1
            },
        };

        public List<CheckOut> ReturnBeverages()
        {
            return beverages;
        }
        public List<CheckOut> ReturnAppetizers()
        {
            return appetizers;
        }
        public List<CheckOut> ReturnMainCourse()
        {
            return mainCourse;
        }
        public List<CheckOut> ReturnDessert()
        {
            return desserts;
        }


    }
}
