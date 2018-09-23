using System.IO;
using Xamarin.Forms;
using ProjetoUNG8.SQLite.Service;
using ProjetoUNG8.Droid.DataBase;

[assembly: Dependency(typeof(DBPath))]
namespace ProjetoUNG8.Droid.DataBase
{
    public class DBPath : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);
            return caminhoBanco;
        }
    }
}