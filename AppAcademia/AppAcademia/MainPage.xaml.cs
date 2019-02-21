using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAcademia
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Telainicialteste());
        }
     
        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaAgendarAvaliação());
            IsPresented = false;

        }

        private void ViewCell_Tapped_1(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaTreino());
            IsPresented = false;
        }

        private void ViewCell_Tapped_2(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaPerguntaseDuvidas());
            IsPresented = false;
        }

        private void ViewCell_Tapped_3(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaDicasAlimentaçãoeTreino());
            IsPresented = false;
        }

        private void ViewCell_Tapped_4(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new Sobre());
            IsPresented = false;
        }

        private void ViewCell_Tapped_5(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaFeedbackProfessores());
            IsPresented = false;
        }

        private void ViewCell_Tapped_6(object sender, EventArgs e)
        {
            Detail.Navigation.PushAsync(new TelaTreino());
            IsPresented = false;
        }
    }
}
