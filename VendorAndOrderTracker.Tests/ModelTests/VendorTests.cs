using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test Vendor","test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string vendorName = "Star Cafe";
      string description = "Diner";
      Vendor newVendor = new Vendor(vendorName,description);

      //Act 
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(vendorName,result);
    }

    [TestMethod]
    public void SetName_SetNamez_String()
    {
      //Arrange
      string vendorName = "Star Cafe";
      string description = "Diner";
      Vendor newVendor = new Vendor(vendorName,description);

      //Act 
      string updatedName = "Moon and Stars Cafe";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName,result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string vendorName = "Star Cafe";
      string description = "Diner";
      Vendor newVendor = new Vendor(vendorName, description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string vendorName = "Star Cafe";
      string description = "Diner";
      Vendor newVendor = new Vendor(vendorName, description);

      //Act
      string updatedDescription = "Restaurant";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_VendorList()
    {
      //Arrange
      List<Vendor> newList = new List<Vendor> {};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsVendors_VendorList()
    {
      //Arrange
      string name01 = "BlueFin Pub";
      string description01 = "Bar";
      string name02 = "Nova's Steak House";
      string description02 = "Restaurant";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);
      List<Vendor> newList = new List<Vendor> {newVendor1,newVendor2};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_VendorsInstantiateWithAnIdandGetterReturnsId_int()
    {
    //Arrange
      string vendorName = "Star Cafe";
      string description = "Diner";
      Vendor newVendor = new Vendor(vendorName, description);

      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "BlueFin Pub";
      string description01 = "Bar";
      string name02 = "Nova's Steak House";
      string description02 = "Restaurant";
      Vendor newVendor1 = new Vendor(name01,description01);
      Vendor newVendor2 = new Vendor(name02,description02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2,result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Croissant Order";
      string orderDescription = "100 Blue Berry filled";
      decimal price = 400.00M;
      Order newOrder = new Order(title,orderDescription,price);
      List<Order> newList = new List<Order> {newOrder};
      
      string vendorName = "Star Cafe";
      string vendorDescription = "Diner";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);


      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList,result);  
    }
  }
}