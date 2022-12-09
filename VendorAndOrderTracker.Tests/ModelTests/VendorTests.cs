using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorAndOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorAndOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
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
  }
}