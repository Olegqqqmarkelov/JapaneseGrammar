using System;
using System.Collections.Generic;
using System.Linq;
using Japanese.Data;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Japanese.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Japanese.Views
{
    public partial class JLPT1 : ContentPage
    {
        public JLPT1()
        {
            InitializeComponent();

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            itemsList.ItemsSource = await App.Database.GetAllItemAsync(1);
        }

        private async void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            Item item = (Item)e.SelectedItem;

            Navigation.PushAsync(new DetailItemPage(item));
        }
    }
}