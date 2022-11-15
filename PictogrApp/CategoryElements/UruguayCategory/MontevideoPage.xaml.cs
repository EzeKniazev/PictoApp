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
    public partial class MontevideoPage : ContentPage
    {
        public MontevideoPage()
        {
            InitializeComponent();
        }
        private async void BtnMontevideoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mercado agricola");
        }

        private async void BtnMontevideoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Palabra montevideo");
        }

        private async void BtnMontevideoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo de los andes");
        }

        private async void BtnMontevideoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Rambla");
        }

        private async void BtnMontevideoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Teatro solis");
        }
    }
}