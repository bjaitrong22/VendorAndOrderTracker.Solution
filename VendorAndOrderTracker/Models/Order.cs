using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Description {get; set;}
    public decimal Price {get; set; }
    public string DateAndTime {get; }
    public int Id {get ; }
    
    public Order(string title,string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
      DateAndTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");

      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }  

    public static Order Find(int searchId)
    {
      return _instances[searchId -1];
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}