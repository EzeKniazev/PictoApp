using PictogrApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PictogrApp.Data;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace PictogrApp
{
    public partial class App : Application
    {
        static SQLiteHelper db;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        public static SQLiteHelper SQLiteDB
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper();
                }
                return db;
            }

        }

  
        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
        }
    }
}
