using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.VacuumCleaners
{
    public class VacuumCleanerViewModel
    {
        public VacuumCleanerViewModel()
        {
        }

        public VacuumCleanerViewModel(VacuumCleaner vacuum)
        {
            this.Id = vacuum.Id;
            this.ProductName = vacuum.ProductName;
            this.Model = vacuum.Model;
            this.Power = vacuum.Power;
            this.NoiseLevel = vacuum.NoiseLevel;
            this.Color = vacuum.Color;
            this.Price = vacuum.Price;
        }
        public string Id { get; set; }

        public string ProductName { get; set; }

        public string Model { get; set; }

        public int Power { get; set; }

        public int NoiseLevel { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }
    }
}
