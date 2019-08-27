using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new StackLayoutDemo();
            //MainPage = new StackLayoutCode();
            //MainPage = new AbsoluteLayoutDemo();
            //MainPage = new AbsoluteLayoutCode();
            //MainPage = new RelativeLayoutDemo();
            //MainPage = new RelativeLayoutCode();
            //MainPage = new GridDemo();
            //MainPage = new GridCode();
            //MainPage = new ScrollViewDemo();
            //MainPage = new ScrollViewCode();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
