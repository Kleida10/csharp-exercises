using System;

public class MenuItem
{
    public string Name { get; set; }
   
    public string Description { get; set; }
   
    public double Price { get; set; }
  
    public DateTime AddedOnDate { get; set; }
   
    
    public int Id { get; set; }
   

    public bool IsNew
    {
        get
        {
            return AddedOnDate.Date >= DateTime.Now.Date.AddDays(-90);
        }
    }

    public enum CategoryType
    {
        Appetizer,
        Lunch,
        Dinner,
        Drinks,
    }
    public CategoryType Category { get; set; }

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
        return Name == item.Name;
    }

    public override int GetHashCode()
    {
        return Id;
    }
}



