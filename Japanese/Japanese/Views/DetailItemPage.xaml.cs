using Japanese.Models;
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
    public partial class DetailItemPage : ContentPage
    {
        public DetailItemPage()
        {
            InitializeComponent();

            /*Title = item.TextJapanese;
            TextExplanation.Text = item.TextExplanation;
            ShortText.Text = item.ShortText;
            TextFormation.Text = item.TextFormation;

            GetExa(item.ID);*/
        }

        /*public async void GetExa(int ID)
        {
            base.OnAppearing();
            List<ExamleModel> model = await App.Database.GetExamleModel(ID);

            itemsExampleList.ItemsSource = model;
        }*/
    }
}