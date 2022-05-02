using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPatitasFelicesProyecto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPatitasFelicesaml : ContentPage
    {
        public LoginPatitasFelicesaml()
        {
            InitializeComponent();
        }

        void clickregistrarse()
        {
            lbl
            label_xname.GestureRecognizers.Add(
            new TapGestureRecognizer()
            {
                Command = new Command(() => {
                    /* Handle the click here */
                })
            });

        }
        private void iniciarsesionLogin_Clicked(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}