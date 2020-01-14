using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.AirConditioners
{
    public class AirConditionerViewModel
    {
        public AirConditionerViewModel()
        {
        }

        public AirConditionerViewModel(AirConditioner air)
        {
            this.Id = air.Id;
            this.ProductName = air.ProductName;
            this.Model = air.Model;
            this.PowerCooling = air.PowerCooling;
            this.PowerHeating = air.PowerHeating;
            this.NoiseLevel = air.NoiseLevel;
            this.Price = air.Price;
        }
        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Model { get; set; }

        public double PowerCooling { get; set; }

        public double PowerHeating { get; set; }

        public int NoiseLevel { get; set; }

        public decimal Price { get; set; }
    }
}
