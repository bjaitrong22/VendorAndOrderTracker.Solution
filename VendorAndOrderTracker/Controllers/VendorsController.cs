using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorAndOrderTracker.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VendorAndOrderTracker.Controllers
{
  public class VendorsController: Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      if (vendorName != null && vendorDescription != null )
      {
        Vendor newVendor = new Vendor(vendorName, vendorDescription);
        return Redirect("/");
      }
      else
      {
        return Redirect("/vendors/error");
      }
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, decimal orderPrice)
    {
      if (orderTitle != null && orderDescription != null && orderPrice >= 0)
      {
      Dictionary<string, object> model = new Dictionary<string, object> ();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order (orderTitle,orderDescription, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show", model);
      }
      else
      {
        return Redirect("/vendors/error");
      }
    }

    [HttpGet("/vendors/error")]
    public ActionResult Error()
    {
      return View();
    }

  }
}