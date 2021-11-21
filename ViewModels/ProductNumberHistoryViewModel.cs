using DDD.Domain.Entities;
using DDD.Domain.Helpers;
using DDD.Domain.Repositories;
using DDD.Infrastructure.Csv;
using System;
using System.Text;
using System.Windows.Forms;

namespace DDD.WinForm.ViewModels
{
    public class ProductNumberHistoryViewModel : ViewModelBase
    {
        private IProductNumberRipository product_number_;

        // 引数なしできたらコンストラクタ（引数あり）にnew ProductNumberCsvを投げる
        public ProductNumberHistoryViewModel()
            :this(new ProductNumberCsv())
        {
            // コンストラクタが二つになる
            // product_number_ = new ProductNumberCsv();
        }

        public ProductNumberHistoryViewModel(
            IProductNumberRipository product_number
            )
        {
            product_number_ = product_number;

            //GetProductNumber = GetProductNumber();
            BaseProductNumberText = string.Empty;
            SubProductNumberText = string.Empty;
        }

        public string BaseProductNumberText { get; set; }
        public string SubProductNumberText { get; set; }

        public void Save()
        {
            Guard.IsStringEmpty(BaseProductNumberText, "入力してください");
            Guard.IsStringEmpty(SubProductNumberText, "入力してください");

            // 確認画面
            DialogResult dialogResult = MessageBox.Show(
                  "保存しますか？",
                  "確認",
                  MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                using (var sw = new
                    System.IO.StreamWriter(
                    @"",
                    true,
                    Encoding.GetEncoding("shift_jis")))
                {
                    sw.Write(BaseProductNumberText);
                    sw.Write(",");
                    sw.Write(SubProductNumberText);
                    sw.WriteLine("");
                }

                //StatusLabelText = "保存しました";
            }
            else
            {
                //StatusLabelText = "キャンセルしました";
            }


            var entity = new ProductNumberEntity(
                BaseProductNumberText,
                SubProductNumberText);

            product_number_.Save(entity);
        }
    }
}
