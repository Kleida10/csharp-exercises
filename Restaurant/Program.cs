using System;

namespace Restaurant
{
    class Menu
    {
        public class Category
        {
            public string appetizer;
            public string lunch;
            public string dinner;
            public string drinks;
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
            public bool IsNew { get; set; }
            public class AddedOnDate
            {
                readonly DateTime addedOnDate = DateTime.Parse("/*stringDate*/", System.Globalization.CultureInfo.InvariantCulture);
            }
        }
    }
}
