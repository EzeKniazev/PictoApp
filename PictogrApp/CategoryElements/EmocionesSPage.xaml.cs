using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.CategoryElements
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmocionesSPage : ContentPage
    {
        public EmocionesSPage()
        {
            InitializeComponent();
        }
        private async void BtnSi_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Si");
        }
        private async void BtnNo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("No");
        }
        private async void BtnEstoyFeliz_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy Feliz");
        }

        private async void BtnEstoyTriste_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy Triste");
        }
        private async void BtnEstoyEnojado_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Estoy Enojado");
        }
        private async void BtnEstaBien_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Esta Bien");
        }

        private async void BtnEstaMal_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Esta Mal");
        }
        private async void BtnEnserio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("¿Una Pregunta?");
        }

        private async void BtnQuiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero");
        }
        private async void BtnQuieroMas_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Quiero Más");
        }
        private async void BtnNoQuiero_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("No Quiero");
        }

        private async void BtnTengo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo");
        }

        //ME PIDE QUE DEJE ESTE ESPACIO, NO SE PORQUE

        private async void BtnTengoCalor_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo Calor");
        }

        private async void BtnTengoFrio_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo Frio");
        }
        private async void BtnTengoMiedo_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Tengo Miedo");
        }
        private async void BtnMeInteresa_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Me Interesa");
        }
        private async void BtnMeDuele_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Me Duele");
        }
        private async void BtnMeDaVerguenza_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Me da Vergüenza");
        }
    }
}