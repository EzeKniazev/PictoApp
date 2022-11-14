using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements.UruguayCategory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtigasPage : ContentPage
    {
        public ArtigasPage()
        {
            InitializeComponent();
        }
        private async void BtnCapital_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Artigas");
        }
        private async void BtnIglesiaSanEugenio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Iglesia San Eugenio");
        }
        private async void BtnJefaturaDePolicia_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Jefatura De Policia");
        }
        private async void BtnPlazaBlatlle_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza Batlle");
        }
        private async void BtnVirgenDeLos33_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Virgen De Los 33");
        }
    }
}