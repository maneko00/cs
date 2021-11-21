using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IProductNumberRipository
    {
        //ProductNumberEntity GetProductNumber(string base_, string sub);
        void Save(ProductNumberEntity product_number);
    }
}
