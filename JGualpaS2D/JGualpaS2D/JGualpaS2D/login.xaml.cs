using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JGualpaS2D
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            if(  (txtDato.Text.Equals("estudiante2023") )  && (txtDatoDos.Text.Equals("uisrael2023")))
            {
                Navigation.PushAsync(new Operacion());
            }
            else
            {
                DisplayAlert("Alerta", "CONTRASEÑA INCORRECTA", "Cerrar");
            }
            
        }
    }
}