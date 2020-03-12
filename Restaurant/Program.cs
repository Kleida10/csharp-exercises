using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    public class Program
    {
        static void Main()
        {
            var menuItems = CreatingMenuItems();
            Menu menu = new Menu(DateTime.Now,DateTime.Now);
            menu.Id = 1;
            foreach(MenuItem item in menuItems)
            {
                menu.AddItem(item);
            }

            menu.PrintAll();
        }
        public static List<MenuItem> CreatingMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            MenuItem menuItem;
            menuItem = new MenuItem(1,DateTime.Now)
            {
                Category = MenuItem.CategoryType.Appetizer,
                Name = "Pizza Rolls",
                Description = "filled with four different cheeses",
                Price = 9.99
            };
            menuItems.Add(menuItem);

            menuItem = new MenuItem(2, DateTime.Now)
            {
                Category = MenuItem.CategoryType.Lunch,
                Name = "Alfredo Pasta",
                Description = "Italian linguini in our special Alfredo sauce",
                Price = 19.89
            };
            menuItems.Add(menuItem);

            menuItem = new MenuItem(3, DateTime.Now)
            {
                Category = MenuItem.CategoryType.Drinks,
                Name = "Margarita",
                Description = "Don Julio tequila with Triple sec and fresh lime",
                Price = 8.99
            };
            menuItems.Add(menuItem);
            return menuItems;
        }
    }
}
