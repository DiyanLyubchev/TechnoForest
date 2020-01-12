using System;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.TVs
{
    public class TvViewModel
    {
        public TvViewModel()
        {
        }

        public TvViewModel(TV tV)
        {
            this.Id = tV.Id;
            this.ProductName = tV.ProductName;
            this.Model = tV.Model;
            this.Size = tV.Size;
            this.Price = tV.Price;
        }

        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Model { get; set; }

        public double? Size { get; set; }

        public decimal? Price { get; set; }
    }
}
