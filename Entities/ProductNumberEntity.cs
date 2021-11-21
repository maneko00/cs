namespace DDD.Domain.Entities
{
    public sealed class ProductNumberEntity
    {
        // 完全コンストラクタパターン
        public ProductNumberEntity(string base_product_number,
                                   string sub_product_number)
        {
            BaseProductNumber = base_product_number;
            SubProductNumber = sub_product_number;
        }

        public string BaseProductNumber { get; }
        public string SubProductNumber { get; }

        // ロジックもここに書く
        // public bool IsOK()
        // {
        // }
    }
}
