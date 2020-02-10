using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using OdeToFood.Web.Components;
using BlazorApp.Components;


namespace OdeToFood.Web.Components
{
    public class InventoryWidget : Controller
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var inventory = new List<InventtoryItem>()
            {
                new InventoryItem() { Name = "banner", Count = 8 },
                new InventoryItem() { Name = "poo", Count = 1 },

                new InventoryItem() { Name = "pee", Count = 8 },

                new InventoryItem() { Name = "cheese", Count = 2 },

                new InventoryItem() { Name = "tacos", Count = 3 },

                new InventoryItem() { Name = "cheetos", Count = 4 },

                new InventoryItem() { Name = "oh noes", Count = 8 }

            }
        }
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
