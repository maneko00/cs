using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IProductNumberRipository
    {
        ProductNumberEntity GetHistory();
        void Save(ProductNumberEntity product_number);
    }
}