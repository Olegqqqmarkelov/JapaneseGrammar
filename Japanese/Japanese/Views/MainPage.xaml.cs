using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Japanese.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Text)
            {
                case "1":
                    await Navigation.PushAsync(new JLPT1());
                    break;
                case "2":
                    await Navigation.PushAsync(new JLPT2());
                    break;
                case "3":
                    await Navigation.PushAsync(new JLPT3());
                    break;
                case "4":
                    await Navigation.PushAsync(new JLPT4());
                    break;
                case "5":
                    await Navigation.PushAsync(new JLPT5());
                    break;

                default:
                    break;
            }
        }
    }
}