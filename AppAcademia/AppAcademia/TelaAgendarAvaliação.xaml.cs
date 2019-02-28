using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace AppAcademia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaAgendarAvaliação : ContentPage
	{
        private object conexao;

        public TelaAgendarAvaliação ()
		{
			InitializeComponent ();
		}

        private void ButtonAgendar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(entryNome.Text) ||
                 String.IsNullOrEmpty(entryDia.Text )||
                 String.IsNullOrEmpty(entryHora.Text))
                 
            {
                DisplayAlert(null, "Não deixe os campos em branco", "OK");
            }
           
        }
    }
}