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
	public partial class ListaTarefas : ContentPage
	{
        private DataBase _db { get; set; }
        private List<Tarefas> listaInterna { get; set; }

		public ListaTarefas ()
		{
			InitializeComponent ();
            _db = new DataBase();
            Listar();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Listar();
        }

        private void Listar()
        {
            listaInterna = _db.GetAllTarefas();
            lvLista.ItemsSource = listaInterna;
        }

        private void EscolheuAction(object sender, ItemTappedEventArgs args)
        {
            Tarefas tarefa = (Tarefas)args.Item;
            (sender as ListView).SelectedItem = null;
            Navigation.PushAsync (new Jogo(tarefa) { Title = "Jogar" });
        }
    }
}