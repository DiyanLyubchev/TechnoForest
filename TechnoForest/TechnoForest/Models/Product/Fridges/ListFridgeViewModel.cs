using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.Fridges
{
    public class ListFridgeViewModel
    {
        public List<FridgeViewModel> Fridges { get; set; }

        public ListFridgeViewModel(IEnumerable<Fridge> fridges)
        {
            this.Fridges = new List<FridgeViewModel>();

            foreach (var fridge in fridges)
            {
                this.Fridges.Add(new FridgeViewModel(fridge));
            }
        }
    }
}
