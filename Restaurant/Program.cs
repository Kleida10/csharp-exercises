using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    class Menu
    {
        public enum Category
        {
            appetizer,
            lunch,
            dinner,
            drinks,
        }

        public class MenuItems
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public double price;
            public double Price
            {
                get { return price; }
                internal set { price = value; }
            }
            public List<MenuItems> MenuItem = new List<MenuItems>();

            public DateTime AddedOnDate { get; set; }
            public bool IsNew

            {
                get
                {
                    return AddedOnDate.Date >= DateTime.Now.Date.AddDays(-90);
                }
            }

        }
    }
}
