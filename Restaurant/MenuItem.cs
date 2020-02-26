using System;

public class MenuItem
{
    public string Name { get; set; }
   
    public string Description { get; set; }
   
    public double Price
    {
        get { return price; }
        internal set { price = value; }
    }

    public DateTime AddedOnDate 
    {
        get { return DateTime.Now.Date; }
    }
    
    public int Id 
    { 
        get { return Id;  }
    }

    public bool IsNew
    {
        get
        {
            return AddedOnDate.Date >= DateTime.Now.Date.AddDays(-90);
        }
    }

    public enum Category
    {
        Appetizer,
        Lunch,
        Dinner,
        Drinks,
    }

    public MenuItem(int id, DateTime addedOnDate)
    {
        Id = id;
        AddedOnDate = addedOnDate;
    }
    
   
    public override string ToString()
    {
        return Name + " (" + Description + ") " + Price;
    }

    public override bool Equals(Object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
       
        MenuItem item = obj as MenuItem;
        return Name == obj.Name;
    }

    public override int GetHashCode()
    {
        return Name;
    }
}
    


