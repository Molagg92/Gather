using System;
using System.Collections.Generic;
using Microsoft.Extensions.Diagnostics.HealthChecks;


namespace Gather.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string ItemName { get; set; }
    public List<VendorItem> VendorItems { get; }
    public List<GuestItem> GuestItems { get; }
    public List<GatheringItem> GatheringItems { get; }
  }
}