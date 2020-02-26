using System;

public class Menu
{
   public DateTime DateCreated
    {
        get { return DateTime.Now; }
    }

    public DateTime DateUpdated
    {
        get { return DateTime.Now; }
    }

    public int Id
    {
        get { return Id; }
    }


    public Menu(DateTime dateCreated, DateTime dateUpdated)
    {
        //why do we need to have an id for Menu too?

        DateCreated = dateCreated;
        DateUpdated = dateUpdated;
    }
      
    public List<MenuItem> menuItems = new List<MenuItem>();

   public void AddItem(string name, string description, double price, DateTime addedOnDate)
    {
        MenuItem item = new MenuItem();

        item.Name = name;
        item.Description = description;
        item.Price = price;
        item.AddedOnDate = addedOnDate;

        menuItems.Add(item);
    }

    public void RemoveItem(string name)
    {
        item.Name = name;
        menuItems.Remove(item);
    }

    public static bool IsNewItem (DateTime date)
    {
        //if the item was added 3months ago is not new
        if (date.Date >= DateTime.Now.Date.AddDays(-90))
        {
            return false;

        }
    }


    public void PrintItem (int idNumber)
    {
        item.Id = idNumber;
        Console.WriteLine(item);
    }

    public void PrintAll()
    {
        Console.WriteLine(menuItems);
    }
    
   //why do i need again those methods here? ToString(), Equals(), and the GetHashCode()
    public override string ToString()
    {
        return menuItems;//??? 
    }
    
    
    public override bool Equals()
    {
        
    }

    public override int GetHashCode()
    {

    }

}

