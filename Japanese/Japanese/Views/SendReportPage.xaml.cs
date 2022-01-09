using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Japanese.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendReportPage : ContentPage
    {
        public SendReportPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Email.ComposeAsync(entryShortText.Text, entryLongText.Text, "asljidh4oh44sfp4f3f@gmail.com");
        }
    }
}