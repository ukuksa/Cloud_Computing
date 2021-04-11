using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace introductionToXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
            "Dial a Number",
            "Would you like to call " + translatedNumber + "?",
            "Yes",
            "No"))
            {
                try
                {
                    PhoneDialer.Open(translatedNumber);
                }
                catch (ArgumentNullException)
                {
                    await DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
                }
                catch (FeatureNotSupportedException)
                {
                    await DisplayAlert("Unable to dial", "Phone dialing not sup‐ported.", "OK");
                }
                catch (Exception)
                {
                    // Other error has occurred.
                    await DisplayAlert("Unable to dial", "Phone dialing failed.",
                   "OK");
                }

            }
        }


        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = phoneNumberText.Text;
            translatedNumber =
            Core.PhonewordTranslator.ToNumber(enteredNumber);
            if (!string.IsNullOrEmpty(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";

            }
        }

    }
}