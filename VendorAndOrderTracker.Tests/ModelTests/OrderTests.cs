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
      Order newOrder = new Order(title,description);
      Assert.AreEqual(typeof(Order),newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      Order newOrder = new Order(title,description);

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
      Order newOrder = new Order(title,description);

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
      Order newOrder = new Order(title,description);

      //Act
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    } 

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Assert
      string title = "Bread Order";
      string description = "100 loaves of rye bread";
      Order newOrder = new Order(title,description);

      //Act
      String updatedDescription = "200 loaves of rye bread";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }   
  }
}
