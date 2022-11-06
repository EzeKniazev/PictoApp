using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictoApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FamiliaPage : ContentPage
    {
        public FamiliaPage()
        {
            InitializeComponent();
        }

        private async void Mama_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Mamá");
        }

        private async void Papa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Papá");
        }

        private async void Abuelos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Abuelos");
        }

        private async void Hermanos_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hermanos");
        }
    }
}