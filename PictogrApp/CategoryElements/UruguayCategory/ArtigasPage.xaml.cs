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
        private async void BtnArtigasA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Iglesia San Eugenio");
        }

        private async void BtnArtigasB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Jefatura de Policía");
        }

        private async void BtnArtigasC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza Batlle");
        }

        private async void BtnArtigasD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Virgen de los 33");
        }
    }
}