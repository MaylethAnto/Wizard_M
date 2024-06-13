using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wizard_M.Views;

namespace Wizard_M
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WizardPage1());
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
