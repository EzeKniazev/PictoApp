using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PictogrApp.Views.Usuarios //POR TEMA DE TIEMPO, ESTA FUNCIÓN NO A SIDO IMPLEMENTADA - PERO SE PREVEE QUE SE HAGA EN UN FUTURO
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioCat : ContentPage
    {
        public InicioCat()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Clicked(object sender, EventArgs e)
        {
            
        }

        private async void BtnRegistrarse_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Usuarios.Registrarse());
        }
    }
}