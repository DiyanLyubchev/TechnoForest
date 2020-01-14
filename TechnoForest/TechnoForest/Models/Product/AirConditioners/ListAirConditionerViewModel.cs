using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.AirConditioners
{
    public class ListAirConditionerViewModel
    {
        public List<AirConditionerViewModel> Air { get; set; }

        public ListAirConditionerViewModel(IEnumerable<AirConditioner> airs)
        {
            this.Air = new List<AirConditionerViewModel>();

            foreach (var air in airs)
            {
                this.Air.Add(new AirConditionerViewModel(air));
            }
        }
    }
}
