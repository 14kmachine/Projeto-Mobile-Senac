using SQLite;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcademia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaDicasAlimentaçãoeTreino : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;
        public TelaDicasAlimentaçãoeTreino ()
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

        private void ButtonPostar_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(entryDicas.Text))                 
            {
                DisplayAlert(null, "Não deixe os campos em branco", "OK");
            }
            else
            {
                var u = new Usuarios
                {
                    dicas = entryDicas.Text
                };

                conexao.InsertAsync(usuarios); //1
                usuarios.Add(u); //2 insert

                DisplayAlert(null, "Dica postada ", "OK");
            }
        }
    }
}