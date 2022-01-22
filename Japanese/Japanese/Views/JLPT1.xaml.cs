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

    public class ViewModel1
    {
        public int ID { get; set; }
        public byte Jplt { get; set; }
        public string TextJapanese { get; set; }
        public bool isFavorite { get; set; }

        public string ShortText { get; set; }
    }

    public partial class JLPT1 : ContentPage
    {
        public JLPT1()
        {
            InitializeComponent();


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            List<ViewModel1> viewModels = new List<ViewModel1>();

            List<Item> items = await App.Database.GetAllItemAsync(5);
            List<TextShortModel> textShorts = await App.Database.GetTextShortModels(5);
            SettingModel setting = await App.Database.GetSettingModel(100);

            foreach (var item1 in items)
            {
                ViewModel1 viewModel = new ViewModel1()
                {
                    ID = item1.ID,
                    Jplt = item1.Jplt,
                    TextJapanese = item1.TextJapanese,
                    isFavorite = item1.isFavorite,
                };
                foreach (var item in textShorts)
                {
                    if(item1.ID == item.IdItem)
                    {
                        switch (setting.Language)
                        {
                            case 0:
                                viewModel.ShortText = item.TextUa;
                                break;
                            case 1:
                                viewModel.ShortText = item.TextEngl;
                                break;
                            case 2:
                                viewModel.ShortText = item.TextRu;
                                break;
                            case 3:
                                viewModel.ShortText = item.TextPl;
                                break;
                            default:
                                viewModel.ShortText = item.TextEngl;
                                break;
                        }
                        break;
                    }
                }

                viewModels.Add(viewModel);
            }



            itemsList.ItemsSource = viewModels;
        }

        /*private async void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            Item item = (Item)e.SelectedItem;

            Navigation.PushAsync(new DetailItemPage(item));
        }*/
    }
}