using System;

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

    public DateTime AddedOnDate { get; set; }
    
    public bool IsNew
    {
        get
        {
            return AddedOnDate.Date >= DateTime.Now.Date.AddDays(-90);
        }
    }

    public void AddItem(string name, string description, double price, DateTime addedOnDate)
    {
        MenuItems item = new MenuItems();

        item.Name = name;
        item.Description = description;
        item.Price = price;
        item.AddedOnDate = addedOnDate;

        MenuItem.Add(item);
    }

    public void RemoveItem()
    {
        MenuItem.Remove();
    }

    public static string NewOrNot()
    {
        //if the item was added 3months ago is not new
        if (date.Date >= DateTime.Now.Date.AddDays(-90))
        {
            return " Not New";

        }
        else
        {
            return "New";
        }
    }

    public string Updated()
    {
        //anytime a change is made save the date
        return "Updated on: ";
    }

    public void Print()
    {
        Console.WriteLine();
    }

    public PrintAll()
    {
        Console.WriteLine(MenuItems);
    }
    public static void Equals()
    {
        //if 2 items are the same show me
    }
}
    


