using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Csv
{
    public class ProductNumberCsv : IProductNumberRipository
    {
        public ProductNumberEntity GetHistory()
        {
            //using(var connection = new )
            string s = "";
            string sub = "";
            return new ProductNumberEntity(
                            s,
                            sub);
        }

        public void Save(ProductNumberEntity product_number)
        {
            throw new System.NotImplementedException();
        }
    }
}
