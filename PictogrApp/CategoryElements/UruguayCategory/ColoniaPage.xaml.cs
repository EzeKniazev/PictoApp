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
    public partial class ColoniaPage : ContentPage
    {
        public ColoniaPage()
        {
            InitializeComponent();
        }
        private async void BtnColoniaA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Calle de los Suspiros");
        }

        private async void BtnColoniaB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Faro");
        }

        private async void BtnColoniaC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Granja Arena");
        }

        private async void BtnColoniaD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Muelle del Puerto de Yates");
        }

        private async void BtnColoniaE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza de los Toros");
        }
    }
}