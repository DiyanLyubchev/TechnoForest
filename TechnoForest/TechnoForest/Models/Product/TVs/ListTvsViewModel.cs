using System.Collections.Generic;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product.TVs
{
    public class ListTvsViewModel
    {
        public List<TvViewModel> Tvs { get; set; }

        public ListTvsViewModel(IEnumerable<TV> tv)
        {
            this.Tvs = new List<TvViewModel>();
            foreach (var itemTv in tv)
            {
                this.Tvs.Add(new TvViewModel(itemTv));
            }
        }
    }
}
