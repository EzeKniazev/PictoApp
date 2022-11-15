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
    public partial class SorianoPage : ContentPage
    {
        public SorianoPage()
        {
            InitializeComponent();
        }
        private async void BtnSorianoA_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Balneario concordia");
        }

        private async void BtnSorianoB_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Castillo de maua");
        }

        private async void BtnSorianoC_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Catedral de soriano");
        }

        private async void BtnSorianoD_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Rambla de soriano");
        }

        private async void BtnSorianoE_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero ir a Timbo");
        }
    }
}