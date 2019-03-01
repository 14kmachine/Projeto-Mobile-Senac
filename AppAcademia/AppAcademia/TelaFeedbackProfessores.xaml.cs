using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcademia
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaFeedbackProfessores : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;
        public TelaFeedbackProfessores ()
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

        private void ButtonFeedback_Clicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(entryDigiteaqui.Text))
           

            {
                DisplayAlert(null, "Não deixe os campos em branco", "OK");
            }
            else
            {
                var u = new Usuarios
                {
                    feedback = entryDigiteaqui.Text
                };

                conexao.InsertAsync(usuarios); //1
                usuarios.Add(u); //2 insert

                DisplayAlert(null, "Feedback Salvo", "OK");
            }
        }
    }
}