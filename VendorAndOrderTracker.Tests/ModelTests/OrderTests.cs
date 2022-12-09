using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class OrderTests: IDisposable 
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetDate_ReturnsDate_DateTime()
    {
      //Arrange 
      string dateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      decimal price = 335.00M;
      Order newOrder = new Order(title,description,price);

      //Act
      string result = newOrder.DateAndTime;

      //Assert
      Assert.AreEqual(dateTime,result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      //Arrange
      List<Order> newList = new List<Order> {};

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
