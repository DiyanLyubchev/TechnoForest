using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.Fridges
{
    public class FridgeViewModel
    {
        public FridgeViewModel(Fridge fridge)
        {
            this.Id = fridge.Id;
            this.ProductName = fridge.ProductName;
            this.Model = fridge.Model;
            this.TotalCapacity = fridge.TotalCapacity;
            this.CapacityRefrigerator = fridge.CapacityRefrigerator;
            this.CapacityFreezer = fridge.CapacityFreezer;
            this.Height = fridge.Height;
            this.Width = fridge.Width;
            this.Color = fridge.Color;
            this.Price = fridge.Price;
        }

        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Model { get; set; }

        public int TotalCapacity { get; set; }

        public int CapacityRefrigerator { get; set; }

        public int CapacityFreezer { get; set; }

        public double Height { get; set; }

        public double Width { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }
    }
}
