using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests 
  {

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "Test Order";
      string description = "Test description";
      decimal price = 1.00M;
      Order newOrder = new Order(title,description,price);
      Assert.AreEqual(typeof(Order),newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      string updatedTitle = "Croissant Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    } 

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      String updatedDescription = "200 loaves of rye bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    } 

    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Decimal()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      decimal result = newOrder.Price;

      //Assert
      Assert.AreEqual(price,result);
    }  

    [TestMethod]
    public void SetPrice_SetPrice_Decimal()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      decimal updatedPrice = 345.20M;
      newOrder.Price = updatedPrice;
      decimal result = newOrder.Price;

      //Assert
      Assert.AreEqual(updatedPrice, result);
    }
  }
}
