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
    public partial class FrutasPage : ContentPage
    {
        public FrutasPage()
        {
            InitializeComponent();
        }
            #region Frutas - Verduras
            private async void BtnArandanos_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Arándanos");
            }
            private async void BtnBanana_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Banana");
            }
            private async void BtnCiruela_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Ciruela");
            }
            private async void BtnFrutilla_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Frutilla");
            }
            private async void BtnGranada_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Granada");
            }
            private async void BtnLimon_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Limon");
            }
            private async void BtnLima_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Limá");
            }
            private async void BtnManzana_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Manzana");
            }
            private async void BtnMandarina_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Mandarina");
            }
            private async void BtnNaranja_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Naranja");
            }
            private async void BtnPalta_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Palta");
            }
            private async void BtnPiña_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Piña");
            }
            private async void BtnPera_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Pera");
            }
            private async void BtnPomelo_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Pomelo");
            }
            private async void BtnUvas_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Uvas");
            }
            #endregion
        }
    }