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
            string genero = "";
            if (Hombre.IsChecked)
            {
                genero = "Hombre";
            }
            else if (Mujer.IsChecked)
            {
                genero = "Mujer";
            }

            List<string> caracteristicasSeleccionadas = new List<string>();

            if (Alto.IsChecked)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "alta" : "alto");
            }
            if (Feo.IsChecked)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "fea" : "feo");
            }
            if (Listo.IsChecked)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "lista" : "listo");
            }
            if (Extravagante.IsChecked)
            {
                caracteristicasSeleccionadas.Add("extravagante");
            }
            if (Raro.IsChecked)
            {
                caracteristicasSeleccionadas.Add(genero == "Mujer" ? "rara" : "raro");
            }
            if (Grande.IsChecked)
            {
                caracteristicasSeleccionadas.Add("grande");
            }

            // Construir la cadena de salida
            string critica = $"{nombre}  eres  ";

            if (caracteristicasSeleccionadas.Count == 1)
            {
                critica += caracteristicasSeleccionadas[0];
            }
            else if (caracteristicasSeleccionadas.Count == 2)
            {
                critica += $"{caracteristicasSeleccionadas[0]} y {caracteristicasSeleccionadas[1]}";
            }
            else if (caracteristicasSeleccionadas.Count > 2)
            {
                for (int i = 0; i < caracteristicasSeleccionadas.Count - 1; i++)
                {
                    critica += $"{caracteristicasSeleccionadas[i]}, ";
                }
                critica += $"y {caracteristicasSeleccionadas[caracteristicasSeleccionadas.Count - 1]}";
            }

            critica += ".";

            // Mostrar la crítica en la interfaz de usuario
            LabelCritica.Text = critica;
        }


    }
}
