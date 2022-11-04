using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppQEEP.ViewModels //ESTE ELEMENTO DE CLASE NO TIENE RELEVANCIA PARA EL PROYECTO - SE PODRA ELIMINAR MAS ADELANTE.
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}