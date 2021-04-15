using PeopleStoreApp.DataContracts;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLab3
{
    public partial class App : Application
    {
        public App()
        {
            var client = RestEase.RestClient.For<IPeopleClient>("http://192.168.1.78:5001/api");

            InitializeComponent();

            MainPage = new MainPage(client);
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
