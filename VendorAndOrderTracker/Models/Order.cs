namespace VendorAndOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description {get; set;}
    public decimal Price {get; }
    
    public Order(string title,string description, decimal price)
    {
      Title = title;
      Description = description;
      Price = price;
    }
    
  }
}