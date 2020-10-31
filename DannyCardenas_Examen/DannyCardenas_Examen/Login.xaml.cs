using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DannyCardenas_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private  async  void Button_Clicked(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var password = txtPassword.Text;

            if(usuario== "estudiante2020" && password== "uisrael2020")
            {
               await Navigation.PushAsync(new Registro(usuario));
           }
           else
            {
               DisplayAlert("Error", "Usuario o contraseña Invalido", "Aceptar"); 
           }


        }
    }
}