using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictoApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmocionesSPage : ContentPage
    {
        public EmocionesSPage()
        {
            InitializeComponent();
        }

        private async void BtnFeliz_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy Feliz");
        }

        private async void BtnTriste_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy triste");
        }

        private async void BtnOkay_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Okay");
        }

        private async void BtnMal_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mal");
        }

        private async void BtnQuiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero");
        }

        private async void BtnNoQuiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("No quiero");
        }

        private async void BtnTengo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo");
        }

        private async void BtnDolor_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Me duele");
        }

        private async void BtnTengoCalor_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo Calor");
        }

        private async void BtnTengoFrio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo frio");
        }
    }
}