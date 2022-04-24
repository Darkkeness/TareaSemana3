using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppClases
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {

        double parcial1 = 0;
        double parcial2 = 0;
        double notaFinal = 0;

        List<Alumno> ListAlum = new List<Alumno>();

        public MenuPage()
        {
            InitializeComponent();
        }

        private void Btn_notas(object sender, EventArgs e)
        {
            Alumno newAlum = new Alumno();

            parcial1 = (Double.Parse(_n11.Text) * 0.3) + (Double.Parse(_n12.Text) * 0.2);

            parcial2 = (Double.Parse(_n21.Text) * 0.3) + (Double.Parse(_n22.Text) * 0.2);

            notaFinal = parcial1 + parcial2;
            newAlum.parcial1 = parcial1;
            newAlum.parcial2 = parcial2;
            newAlum.notaFinal = notaFinal;
            newAlum.nombre = _nombre.Text;
            ListAlum.Add(newAlum);
            AlumnosView.ItemsSource = ListAlum;

        }

        private void AlumnosView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Alumno alumSelect = (Alumno) e.SelectedItem;

            nombre.Text = alumSelect.nombre;
            nota1.Text =  alumSelect.parcial1.ToString();
            nota2.Text = alumSelect.parcial2.ToString();
            notaF.Text = alumSelect.notaFinal.ToString();


        }
    }
}