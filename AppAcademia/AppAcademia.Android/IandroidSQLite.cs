using System.IO;
using SQLite;

[assembly: Xamarin.Forms.Dependency(typeof(AppAcademia.Droid.IandroidSQLite))] //diretiva de compilação
namespace AppAcademia.Droid
{
    public class IandroidSQLite : ISQLite
    {
        public SQLiteAsyncConnection AcessarDB()
        {
            var pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var banco = Path.Combine(pasta, "AppSQLite.db");

            return new SQLiteAsyncConnection(banco);
        }
    }
}