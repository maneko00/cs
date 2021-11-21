using DDD.Infrastructure.Fake;
using DDD.WinForm.ViewModels;
using System.Windows.Forms;

namespace DDD.WinForm.Views
{
    public partial class HistoryView : Form
    {
        private ProductNumberHistoryViewModel view_model_
            = new ProductNumberHistoryViewModel(new ProductNumberHistoryFake());
        public HistoryView()
        {
            InitializeComponent();
        }
    }
}
