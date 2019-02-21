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
	public partial class TelaRecuperarSenha : ContentPage
	{
		public TelaRecuperarSenha ()
		{
			InitializeComponent ();
		}

        private async void ButtonEnviar_Clicked(object sender, EventArgs e)
        {
            var Enviar = new TelaCodigo();
            await Navigation.PushModalAsync(Enviar);
        }
    }
}