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
    public partial class CerroLargoPage : ContentPage
    {
        public CerroLargoPage()
        {
            InitializeComponent();
        }
        private async void BtnCerroLargoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Catedral Nuestra Señora");
        }

        private async void BtnCerroLargoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Fuente de los 200 Años");
        }

        private async void BtnCerroLargoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Lago Merin");
        }

        private async void BtnCerroLargoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo Historico General");
        }

        private async void BtnCerroLargoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo Postal del Chuy");
        }
    }
}