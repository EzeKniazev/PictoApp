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
    public partial class LavallejaPage : ContentPage
    {
        public LavallejaPage()
        {
            InitializeComponent();
        }
        private async void BtnLavallejaA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Catedral de minas");
        }

        private async void BtnLavallejaB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Cerro arequita");
        }

        private async void BtnLavallejaC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Museo de replicas en miniaturas");
        }

        private async void BtnLavallejaD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Parque salto del penitente");
        }

        private async void BtnLavallejaE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Plaza libertad");
        }
    }
}