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
    public partial class SaltoPage : ContentPage
    {
        public SaltoPage()
        {
            InitializeComponent();
        }
        private async void BtnSaltoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Gruta del padre pio");
        }

        private async void BtnSaltoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("posada del siglo 21");
        }

        private async void BtnSaltoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Represa de salto");
        }

        private async void BtnSaltoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Termas de arapey");
        }

        private async void BtnSaltoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Termas de daiman");
        }
    }
}