using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Program
    {

        public static List<MenuItem> CreatingMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            MenuItem menuItem;
            menuItem = new MenuItem()
            {
                Category = MenuItem.Category.Appetizer,
                Name = "Pizza Rolls",
                Description = "filled with four different cheeses",
                Price = 9.99
            };
            menuItems.Add(menuItem);

            menuItem = new MenuItem()
            {
                Category = MenuItem.Category.Lunch,
                Name = "Alfredo Pasta",
                Description = "Italian linguini in our special Alfredo sauce",
                Price = 19.89
            };
            menuItems.Add(menuItem);

            menuItem = new MenuItem()
            {
                Category = MenuItem.Category.Drinks,
                Name = "Margarita",
                Description = "Don Julio tequila with Triple sec and fresh lime",
                Price = 8.99
            };
            menuItems.Add(menuItem);
            return menuItems;
        }
    }
}
