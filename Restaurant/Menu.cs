using System;
using System.Collections.Generic;

public class Menu
{
   public DateTime DateCreated { get; set; }
   

    public DateTime DateUpdated { get; set; }
   

    public int Id { get; set; }
   

    public Menu(DateTime dateCreated, DateTime dateUpdated)
    {
        //why do we need to have an id for Menu too?

        DateCreated = dateCreated;
        DateUpdated = dateUpdated;
    }
      
    public List<MenuItem> menuItems = new List<MenuItem>();

   public void AddItem(MenuItem item)
    {
        menuItems.Add(item);
    }

    public void RemoveItem(MenuItem item)
    {
        menuItems.Remove(item);
    }

    public static bool IsNewItem (DateTime date)
    {
        //if the item was added 3months ago is not new
        if (date.Date >= DateTime.Now.Date.AddDays(-90))
        {
            return false;

        }
        else
        {
            return true;
        }
    }

    public override string ToString()
    {
        return Id.ToString();
    }
    public void PrintItem (MenuItem item)
    {
        Console.WriteLine(item);
    }

    public void PrintAll()
    {
        foreach(MenuItem item in menuItems)
        {
           Console.WriteLine(item);

        }
    }
    
   
}

