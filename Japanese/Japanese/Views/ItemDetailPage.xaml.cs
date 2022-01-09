using Japanese.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Japanese.Views
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