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

        private async void Feliz_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy Feliz");
        }

        private async void Triste_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy triste");
        }

        private async void Okay_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Okay");
        }

        private async void Mal_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mal");
        }

        private async void Quiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero");
        }

        private async void NoQuiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("No quiero");
        }

        private async void Tengo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo");
        }

        private async void Dolor_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Me duele");
        }

        private async void TengoCalor_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo Calor");
        }

        private async void TengoFrio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo frio");
        }
    }
}