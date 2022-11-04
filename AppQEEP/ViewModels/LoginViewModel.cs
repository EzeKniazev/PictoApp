using AppQEEP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppQEEP.ViewModels //ELEMENTO CLASE DE LOGINPAGE
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            //El prefijo `//` cambia a una pila de navegación diferente en lugar de empujar a la activa
            await Shell.Current.GoToAsync($"//{nameof(CategoriesPage)}");
        }
    }
}
