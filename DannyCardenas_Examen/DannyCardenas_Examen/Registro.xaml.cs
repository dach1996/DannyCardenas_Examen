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
    public partial class Registro : ContentPage
    {
        private double valorInicial = 1800;
        private string nombreUsuario;
        private string usuario;
        private double cuotasPagar;
        public Registro(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuario.Text = "Bienvenido: "+usuario;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try {
                var montoInicial = double.Parse(txtMontoInicial.Text);
                if (montoInicial > 0 && montoInicial < 1800)
                {
                    if (txtNombre.Text != "")
                    {
                        cuotasPagar = +(((valorInicial - montoInicial) / 3) * 1.05);
                        txtPagoMensual.Text = "$ " + cuotasPagar.ToString();
                        DisplayAlert("Correcto", "Elemento Guardado con éxito", "Cerrar");
                    }
                    else
                    {
                        DisplayAlert("Error", "Ingrese todos los Datos", "Cerrar");

                    }
                    
                }
                else
                {
                    DisplayAlert("Error", "Ha ocurrido un error por favor revice los datos que estén correctamente ingresados.", "Cerrar");
                }
            }
            catch(Exception  ex)
            {
                DisplayAlert("Error", "Ha ocurrido un error por favor revice los datos que estén correctamente ingresados.", "Cerrar");
            }
            
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            nombreUsuario = txtNombre.Text;
            await Navigation.PushAsync(new Resumen(usuario,nombreUsuario,cuotasPagar*3));
        }

      
    }
}