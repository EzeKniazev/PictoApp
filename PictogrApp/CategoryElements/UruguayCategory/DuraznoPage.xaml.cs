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
    public partial class DuraznoPage : ContentPage
    {
        public DuraznoPage()
        {
            InitializeComponent();
        }
        private async void BtnDuraznoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Agua Clara");
        }

        private async void BtnDuraznoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Bioparque Washington");
        }

        private async void BtnDuraznoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Grutas de Reyles");
        }

        private async void BtnDuraznoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Iglesia San Pedro");
        }

        private async void BtnDuraznoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo Historico");
        }
    }
}