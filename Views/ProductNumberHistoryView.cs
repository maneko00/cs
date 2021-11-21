using DDD.WinForm.ViewModels;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class ProductNumberHistoryView : Form
    {
        private ProductNumberHistoryViewModel view_model_
            = new ProductNumberHistoryViewModel();

        public ProductNumberHistoryView()
        {
            InitializeComponent();

            //テータバインディングは今回しなくていい
            //this.BaseProductNumberTextBox.DadaBingings.Add(
            //    "TextBox", view_model_, nameof(view_model_.BaseProductNumberText));
        }

        private void SaveButton_Click(object sender, System.EventArgs e)
        {
            view_model_.Save();
        }
    }
}
