using SQLite;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAcademia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TelaTreino : ContentPage
	{
        private SQLiteAsyncConnection conexao;
        private ObservableCollection<Usuarios> usuarios;

        public TelaTreino ()
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

        private void ViewCell_Tapped(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_1(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_2(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_3(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_4(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_5(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_6(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_7(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_8(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_9(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_10(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_11(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_12(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_13(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_14(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_15(object sender, EventArgs e)
        {

        }

        private void ViewCell_Tapped_16(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Clicked(object sender, EventArgs e)
        {

            if(String.IsNullOrEmpty(entryNumero1.Text) ||
             String.IsNullOrEmpty(entryPesoSerie1.Text) ||
             String.IsNullOrEmpty(entryPeso1.Text) ||
             String.IsNullOrEmpty(entryNumero2.Text)||
             String.IsNullOrEmpty(entryPesoSerie2.Text) ||
             String.IsNullOrEmpty(entryPeso2.Text) ||
             String.IsNullOrEmpty(entryNumero3.Text) ||
             String.IsNullOrEmpty(entryPesoSerie3.Text)||
             String.IsNullOrEmpty(entryNumero4.Text) ||
             String.IsNullOrEmpty(entryPesoSerie4.Text) ||
             String.IsNullOrEmpty(entryPeso4.Text) ||
             String.IsNullOrEmpty(entryNumero5.Text)||
             String.IsNullOrEmpty(entrySerie5.Text) ||
             String.IsNullOrEmpty(entryPeso5.Text) ||
             String.IsNullOrEmpty(entryNumero6.Text) ||
             String.IsNullOrEmpty(entrySerie6.Text) ||
             String.IsNullOrEmpty(entryPeso6.Text) ||
             String.IsNullOrEmpty(entryNumero7.Text)||
             String.IsNullOrEmpty(entrySerie7.Text) ||
             String.IsNullOrEmpty(entryPeso7.Text) ||
             String.IsNullOrEmpty(entryNumero8.Text) ||
             String.IsNullOrEmpty(EntrySerie8.Text) ||
             String.IsNullOrEmpty(entryPeso8.Text))

            {
                DisplayAlert(null, "Não deixe os campos em branco", "OK");
            }
            else
            {
                var u = new Usuarios
                {
                   Numero1 = entryNumero1.Text,
                   Numero2 = entryNumero2.Text,
                   Numero3 = entryNumero2.Text,
                   Numero4 = entryNumero3.Text,
                   Numero5 = entryNumero4.Text,
                   numero6 = entryNumero5.Text,
                   numero7 = entryNumero6.Text,
                   numero8 = entryNumero7.Text,
                   PesoSerie1 = entryPesoSerie1.Text,
                   PesoSerie2 = entryPesoSerie2.Text,
                   PesoSerie3 = entryPesoSerie3.Text,
                   PesoSerie4 = entryPesoSerie4.Text,
                   Serie5 = entrySerie5.Text,
                   Serie6 = entrySerie6.Text,
                   Serie7 = entrySerie7.Text,
                   Serie8 = EntrySerie8.Text,
                   Peso1 = entryPeso1.Text,
                   Peso2 = entryPeso2.Text,
                   Peso3 = entryPeso3.Text,
                   Peso4 = entryPeso4.Text,
                   Peso5 = entryPeso5.Text,
                   Peso6 = entryPeso6.Text,
                   Peso7 = entryPeso7.Text,
                   Peso8 = entryPeso8.Text,                                      
                };

                conexao.InsertAsync(usuarios); //1
                usuarios.Add(u); //2 insert

                DisplayAlert(null, "Treino Salvo", "OK");

            }

        }
    }
}