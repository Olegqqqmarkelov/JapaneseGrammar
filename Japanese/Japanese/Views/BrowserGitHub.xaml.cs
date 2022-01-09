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
    public partial class BrowserGitHub : ContentPage
    {
        public BrowserGitHub()
        {
            InitializeComponent();

            Launcher.OpenAsync("https://github.com/Olegqqqmarkelov/JapaneseGrammar");
        }
    }
}