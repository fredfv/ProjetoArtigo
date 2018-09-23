using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProjetoUNG8.SQLite.Models;
using ProjetoUNG8.SQLite.Service;

namespace ProjetoUNG8.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : TabbedPage
	{
        private DataBase _db { get; set; }

		public Home ()
		{
			InitializeComponent ();
            _db = new DataBase();
            IniciarTelas();
		}

        private void IniciarTelas()
        {
            foreach (var tabs in this.Children.ToList())
                Children.RemoveAt(0);

            Children.Add(new ListaTarefas() { Title = "Tarefas" });
            Children.Add(new ListarTarefasEfetuadas() { Title = "Jogos" });
        }

        private void GerarAction(object sender, EventArgs args)
        {
            List<Tarefas> aux = _db.GetAllTarefas();

            if (aux.Count == 0)
                _db.CriarBase();

            IniciarTelas();
        }
    }
}