using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcademia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLogin : ContentPage
	{
		public PageLogin ()
		{
			InitializeComponent();
		}

               

        private async void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
            if (entryLogin.Text == "admin" && entrySenha.Text == "admin")
            {
                //ABRIR PAGINA MASTER DO APP (de forma modal)
                var page = new MainPage();
                await Navigation.PushModalAsync(page);


            }
            else
            {
                await DisplayAlert("Ops...", "Login e/ou senha incorretos", "OK");
            }
        }

        private void ButtonCadastro_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRecuperarSenha_Clicked(object sender, EventArgs e)
        {

        }
    }
}