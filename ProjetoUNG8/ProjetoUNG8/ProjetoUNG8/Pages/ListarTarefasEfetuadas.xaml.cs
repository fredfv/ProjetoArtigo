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
	public partial class ListarTarefasEfetuadas : ContentPage
	{
        DataBase _db { get; set; }
        private List<Tarefa> ListaInterna { get; set; }
        private List<Tarefa> ListaFiltrada { get; set; }


        public ListarTarefasEfetuadas ()
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
            ListaInterna = _db.GetAllTarefa();
            lvLista.ItemsSource = ListaInterna;
        }

        private void DigitandoAction(object sender, TextChangedEventArgs args)
        {
            if (((Entry)sender).Text.Count() > 0)
            {
                ListaFiltrada = ListaInterna.Where(a => a.Nome.ToUpper().StartsWith(args.NewTextValue.ToUpper()) || a.Dificuldade.ToString().StartsWith(args.NewTextValue)).ToList();
                lvLista.ItemsSource = ListaFiltrada;
            }
            else
            {
                lvLista.ItemsSource = ListaInterna;
            }
        }

    }
}