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
      string title = "Bread Order";
      
      Order newOrder = new Order(title);
      Assert.AreEqual(typeof(Order),newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Bread Order";
      Order newOrder = new Order(title);

      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }
  }
}
