using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.VacuumCleaners
{
    public class ListVacuumCleanersViewModel
    {
        public List<VacuumCleanerViewModel> Vacuums { get; set; }

        public ListVacuumCleanersViewModel(IEnumerable<VacuumCleaner> vacuums)
        {
            this.Vacuums = new List<VacuumCleanerViewModel>();

            foreach (var vacuum in vacuums)
            {
                this.Vacuums.Add(new VacuumCleanerViewModel(vacuum));
            }
        }
    }
}
