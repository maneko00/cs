using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Csv
{
    public class ProductNumberCsv : IProductNumberRipository
    {
        //public ProductNumberEntity GetProductNumber(string s, string sub)
        //{
            
        //    return new ProductNumberEntity(
        //                    s,
        //                    sub);
        //}

        public void Save(ProductNumberEntity product_number)
        {
            throw new System.NotImplementedException();
        }
    }
}
