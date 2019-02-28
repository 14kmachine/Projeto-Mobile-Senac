using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcademia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageLogin : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;

        public PageLogin()
        {
            InitializeComponent();
            conexao = DependencyService.Get<ISQLite>().AcessarDB();
        }

              
        private async void ButtonEntrar_Clicked(object sender, EventArgs e)
        {
           if(entryLogin.Text == "admin" && entrySenha.Text == "admin")
           {
                var page = new MainPage();
                await Navigation.PushModalAsync(page);
           }
           else
           {
                await DisplayAlert("Ops...", "Login e/ou senha incorreta", "OK");
           }
        }

        private async void ButtonCadastro_Clicked(object sender, EventArgs e)
        {
            var Cadastro = new TelaCadastro();
            await Navigation.PushModalAsync(Cadastro);

        }

        private async void ButtonRecuperarSenha_Clicked(object sender, EventArgs e)
        {
            var RecuperarSenha = new TelaRecuperarSenha();
            await Navigation.PushModalAsync(RecuperarSenha);
        }

      
    }
}