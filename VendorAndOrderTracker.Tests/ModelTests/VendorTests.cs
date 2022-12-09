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
      Vendor newVendor = new Vendor("test Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string vendorName = "Star Cafe";
      Vendor newVendor = new Vendor(vendorName);

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
      Vendor newVendor = new Vendor(vendorName);

      //Act 
      string updatedName = "Moon and Stars Cafe";
      newVendor.Name = updatedName;
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(updatedName,result);
    }
  }
}