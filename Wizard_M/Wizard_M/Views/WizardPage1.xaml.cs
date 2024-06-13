using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wizard_M.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wizard_M.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WizardPage1 : ContentPage
    {
        public WizardPage1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WizardPage2());
        }
    }
}