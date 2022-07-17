using flyout_item_styles.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace flyout_item_styles.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}