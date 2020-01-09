using System;

namespace TechnoForest_Service.CustomException
{
    public class ProductExeption : Exception
    {
        public ProductExeption(string masege)
    : base(String.Format(masege))
        {

        }
    }
}
