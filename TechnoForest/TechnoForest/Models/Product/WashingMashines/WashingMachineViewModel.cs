using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.WashingMashines
{
    public class WashingMachineViewModel
    {
        public WashingMachineViewModel()
        {
        }

        public WashingMachineViewModel(WashingMachine machine)
        {
            this.Id = machine.Id;
            this.ProductName = machine.ProductName;
            this.Model = machine.Model;
            this.WashingCapacity = machine.WashingCapacity;
            this.Price = machine.Price;
            this.Picture = machine.Picture;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public string Model { get; set; }

        public int? WashingCapacity { get; set; }

        public decimal? Price { get; set; }

        public string Picture { get; set; }
    }
}
