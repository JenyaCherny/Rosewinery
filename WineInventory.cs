using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WineInventoryBase
{
    public WineClass[] Wineinventory { get; set; }
}

public class WineClass
{
    public string WineName { get; set; }
    public string Description { get; set; }
    public string Quantity { get; set; }
    public string SupplierName { get; set; }
    public string Price { get; set; }
}

