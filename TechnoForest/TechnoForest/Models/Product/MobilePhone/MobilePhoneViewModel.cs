using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product
{
    public class MobilePhoneViewModel
    {
        public MobilePhoneViewModel(MobilePhone phone)
        {
            this.Id = phone.Id;
            this.ProductName = phone.ProductName;
            this.Model = phone.Model;
            this.SizeOfDisplay = phone.SizeOfDisplay;
            this.Color = phone.Color;
            this.Memory = phone.Memory;
            this.Price = phone.Price;
            this.Picture = phone.Picture;
        }

        public MobilePhoneViewModel()
        {
        }

        public int Id { get; set; }
        public string ProductName { get; set; }

        public string Memory { get; set; }

        public string Model { get; set; }

        public double? SizeOfDisplay { get; set; }

        public string Color { get; set; }

        public decimal? Price { get; set; }

        public string Picture { get; set; }
    }
}
