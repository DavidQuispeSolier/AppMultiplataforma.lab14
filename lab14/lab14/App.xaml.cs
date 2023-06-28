using lab14.DataContext;
using lab14.Views;
using lab14.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab14
{
    public partial class App : Application
    {
        public App()

        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new VestimentaView();
        }


        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
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
