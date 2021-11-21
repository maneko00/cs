using DDD.Domain.Entities;
using DDD.Domain.Helpers;
using DDD.Domain.Repositories;
using System;

namespace DDD.WinForm.ViewModels
{
    public class ProductNumberHistoryViewModel : ViewModelBase
    {
        //private IProductNumberRipository product_number_;

        public ProductNumberHistoryViewModel(
            //IProductNumberRipository product_number
            )
        {
            //product_number_ = product_number;

            BaseProductNumberText = string.Empty;
            SubProductNumberText = string.Empty;
        }

        public string BaseProductNumberText { get; set; }
        public string SubProductNumberText { get; set; }

        public void Save()
        {
            Guard.IsStringEmpty(BaseProductNumberText, "入力してください");
            Guard.IsStringEmpty(SubProductNumberText, "入力してください");

            var entity = new ProductNumberEntity(
                BaseProductNumberText,
                SubProductNumberText);

            //product_number_.Save(entity);
        }
    }
}
