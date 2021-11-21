using DDD.Domain.Entities;
using DDD.Domain.Repositories;

namespace DDD.Infrastructure.Fake
{
    public class ProductNumberHistoryFake : IProductNumberRipository
    {
        public ProductNumberEntity GetHistory()
        {
            throw new System.NotImplementedException();
        }

        public void Save(ProductNumberEntity product_number)
        {
            throw new System.NotImplementedException();
        }
    }
}
