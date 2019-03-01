using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;

namespace AppAcademia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaAgendarAvaliação : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;

        //private object conexao;

        public TelaAgendarAvaliação ()
		{
			InitializeComponent ();
            conexao = DependencyService.Get<ISQLite>().AcessarDB();
            conexao.CreateTableAsync<Usuarios>();
        }

        protected async override void OnAppearing()
        {
            var listar = await conexao.Table<Usuarios>().ToListAsync(); //select
            usuarios = new ObservableCollection<Usuarios>(listar);
            base.OnAppearing();
        }

        private void ButtonAgendar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(entryNome.Text) ||
                String.IsNullOrEmpty(entryDia.Text )||
                String.IsNullOrEmpty(entryHora.Text))
                 
            {
                DisplayAlert(null, "Não deixe os campos em branco", "OK");
            }
            else
            {
                var u = new Usuarios
                {
                    agendarnome = entryNome.Text,
                    dia = entryDia.Text,
                    hora = entryHora.Text,
                };
                
                conexao.InsertAsync(usuarios); //1
                usuarios.Add(u); //2 insert

                DisplayAlert(null, "Avaliação Agendada", "OK");
            }
           
        }
    }
}