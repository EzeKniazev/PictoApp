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
    public partial class RioNegroPage : ContentPage
    {
        public RioNegroPage()
        {
            InitializeComponent();
        }
        private async void BtnRioNegroA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Balneario las cañas");
        }

        private async void BtnRioNegroB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo de la revolucion industrial");
        }

        private async void BtnRioNegroC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Parque roosevelt");
        }

        private async void BtnRioNegroD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Puerto viejo");
        }

        private async void BtnRioNegroE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Teatro miguel");
        }
    }
}