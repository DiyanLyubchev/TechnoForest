using System.Collections.Generic;
using TechnoForest_Data.Entity;

namespace TechnoForest.Models.Product
{
    public class ListMobilePhoneViewModel
    {
        public List<MobilePhoneViewModel> Phone { get; set; }
        public ListMobilePhoneViewModel(IEnumerable<MobilePhone> phones)
        {
            this.Phone = new List<MobilePhoneViewModel>();
            foreach (var phone in phones)
            {
                this.Phone.Add(new MobilePhoneViewModel(phone));
            }
        }
    }
}
