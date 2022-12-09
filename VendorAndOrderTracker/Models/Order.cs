using System;

namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description {get; set;}
    public decimal Price {get; set; }
    public string DateAndTime {get; }
    
    public Order(string title,string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
      DateAndTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
    }
    
  }
}