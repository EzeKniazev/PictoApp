using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements.ComidasCategory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerdurasPage : ContentPage
    {
        public VerdurasPage()
        {
            InitializeComponent();
        }
        private async void BtnAcelga_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Acelga");
        }
        private async void BtnAjo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ajo");
        }
        private async void BtnBoniato_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Boniato");
        }
        private async void BtnBrocoli_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Brócoli");
        }
        private async void BtnCebolla_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Cebolla");
        }
        private async void BtnCalabacin_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Calabacín");
        }
        private async void BtnEspinaca_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Espinaca");
        }
        private async void BtnLechuga_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Lechuga");
        }
        private async void BtnMorron_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Morrón");
        }
        private async void BtnNabo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Nabo");
        }
        private async void BtnPapa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Papa");
        }
        private async void BtnPuerro_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Puerro");
        }
        private async void BtnPepino_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Pepino");
        }
        private async void BtnRemolacha_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Remolacha");
        }
        private async void BtnRepollo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Repollo");
        }
        private async void BtnRabano_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Rabano");
        }
        private async void BtnRucula_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Rúcula");
        }
        private async void BtnTomate_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tomate");
        }
        private async void BtnTomateCherry_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tomate Cherry");
        }
        private async void BtnZanahoria_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Zanahoria");
        }
        private async void BtnZapallo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Zapallo");
        }
    }
}