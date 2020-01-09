using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnoForest.Models.ShoppingCarts;

namespace TechnoForest.Models.ShopingCarts
{
    public class SearchResultsViewModel
    {
        public SearchResultsViewModel()
        {
        }

        public SearchResultsViewModel(IEnumerable<ShoppingCartViewModel> searchViewModel)
        {
            this.Result = searchViewModel;
        }

        public IEnumerable<ShoppingCartViewModel> Result { get; set; } = new List<ShoppingCartViewModel>();
    }
}
