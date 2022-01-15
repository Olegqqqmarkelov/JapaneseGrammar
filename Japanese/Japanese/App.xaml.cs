using Japanese.Views;
using System;
using Japanese.Data;
using Xamarin.Forms;
using Japanese.Models;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Collections.Generic;

namespace Japanese
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "items5.db";
        public static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(
                    Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();


            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
