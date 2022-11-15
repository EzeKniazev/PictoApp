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
    public partial class FloresPage : ContentPage
    {
        public FloresPage()
        {
            InitializeComponent();
        }
        private async void BtnFloresA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Balneario don ricardo");
        }

        private async void BtnFloresB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ecoparque talice");
        }

        private async void BtnFloresC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Parque centenario");
        }

        private async void BtnFloresD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza constitucion");
        }

        private async void BtnFloresE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza walter echeverria");
        }
    }
}