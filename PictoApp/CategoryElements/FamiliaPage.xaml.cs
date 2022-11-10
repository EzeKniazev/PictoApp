using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FamiliaPage : ContentPage
    {
        public FamiliaPage()
        {
            InitializeComponent();
        }

        private async void BtnMama_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mamá");
        }

        private async void BtnPapa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Papá");
        }

        private async void BtnMadres_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Madres");
        }

        private async void BtnPadres_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Padres");
        }
        private async void BtnMamaYPapa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mamá y Papá");
        }
        private async void BtnHija_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hija");
        }
        private async void BtnHijo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hijo");
        }
        private async void BtnHijas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hijas");
        }
        private async void BtnHijos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hijos");
        }
        private async void BtnHermano_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hermano");
        }
        private async void BtnHermana_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hermana");
        }
        private async void BtnHermanos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hermanos");
        }
        private async void BtnHermanas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hermanas");
        }
        private async void BtnAbuela_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Abuela");
        }
        private async void BtnAbuelo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Abuelo");
        }
        private async void BtnAbuelos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Abuelos");
        }
        private async void BtnTio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tío");
        }
        private async void BtnTia_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tía");
        }
        private async void BtnPrimo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Primo");
        }
        private async void BtnPrima_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Prima");
        }
        private async void BtnPrimos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Primos");
        }
        private async void BtnPrimas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Primas");
        }
    }
}