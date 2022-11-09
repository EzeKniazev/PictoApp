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
    public partial class ComidasPage : ContentPage
    {
        public ComidasPage()
        {
            InitializeComponent();
        }

        private async void BtnAsado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Asado");
        }
        private async void BtnMate_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mate");
        }
        private async void BtnTortaFrita_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Torta Frita");
        }
        private async void BtnDulceDeLeche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Dulce de Leche");
        }
        private async void BtnChivito_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chivito");
        }
        private async void BtnVerduras_Clicked(object sender, EventArgs e)
        {
            //await TextToSpeech.SpeakAsync("Quiero tomar Agua");
        }
        private async void BtnMilanesaALPan_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Milanesa al Pan");
        }
        private async void BtnEmpanada_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Empanada");
        }
        private async void BtnGarrapiñada_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Garrapiñada");
        }
        private async void BtnHamburguesa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hamburguesa");
        }
        private async void BtnHelado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Helado");
        }
        private async void BtnFrutas_Clicked(object sender, EventArgs e)
        {
            //await TextToSpeech.SpeakAsync("Quiero tomar Agua");
        }
        private async void BtnChorizo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chorizo");
        }
        private async void BtnCaramelo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Caramelo");
        }
        private async void BtnChicle_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chicle");
        }
        private async void BtnRefuerzo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Refuerzo");
        }
        private async void BtnChocolatada_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Chocolatada");
        }
        private async void BtnGalletas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Galletitas");
        }
        private async void BtnCafe_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Café");
        }
        private async void BtnLeche_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Leche");
        }
        private async void BtnYogur_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Yogur");
        }
        private async void BtnLicuado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Licuado");
        }
    }
}