using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using OdeToFood.Web.Components;



namespace OdeToFood.Web.Components
{
    public class InventoryWidget : Controller
    {
        
    }

    public class InventoryItem
    {
        public InventoryItem()
        {
        }

        public string Name { get; set; }
        public int Count { get; set; }
    }
}
