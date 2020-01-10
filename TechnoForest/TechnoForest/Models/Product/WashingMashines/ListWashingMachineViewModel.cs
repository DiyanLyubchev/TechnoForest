using System.Collections.Generic;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.WashingMashines
{
    public class ListWashingMachineViewModel
    {
        public List<WashingMachineViewModel> WashingMashine { get; set; }
        public ListWashingMachineViewModel(IEnumerable<WashingMachine> washingMachines)
        {
            this.WashingMashine = new List<WashingMachineViewModel>();
            foreach (var machine in washingMachines)
            {
                this.WashingMashine.Add(new WashingMachineViewModel(machine));
            }
        }
    }
}
