using System;
using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name {get; }
    public Vendor(string vendorName)
    {
      Name = vendorName;
    }
  }

}
