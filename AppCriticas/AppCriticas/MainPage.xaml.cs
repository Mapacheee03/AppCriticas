using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCriticas
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void MostrarCriticas_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string genero = Hombre.IsChecked ? "Hombre" : "Mujer";
            string caracteristicas = "";

            if (Alto.IsChecked)
                caracteristicas += "ALTO ";
            if (Feo.IsChecked)
                caracteristicas += "FEO ";
            if (Listo.IsChecked)
                caracteristicas += "LISTO y ";    
            if (Extravagante.IsChecked)
                caracteristicas += "EXTRAVAGANTE. ";

            LabelCritica.Text = $"{nombre} es {genero} tambien es {caracteristicas.TrimEnd(' ', ',')}";
         

            DatosIngresados.IsVisible = true;
        }
    }
}
