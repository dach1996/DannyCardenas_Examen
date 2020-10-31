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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombreUsuario, double totalPagar )
        {
            InitializeComponent();
            txtNombreUsuario.Text = nombreUsuario;
            txtUsuario.Text = usuario;
            txtPagoMensual.Text = "$ "+(totalPagar / 3);
            txtTotalPagar.Text= "$ " + (totalPagar);
        }
    }
}