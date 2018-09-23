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
	public partial class Jogo : ContentPage
	{
        DataBase _db { get; set; }
        JogoOpcoes jogadaatual { get; set; }
        Tarefa tarefaAtual { get; set; }

        public Jogo (Tarefas tarefa)
		{
			InitializeComponent ();
            _db = new DataBase();
            jogadaatual = new JogoOpcoes(tarefa);
            BindingContext = jogadaatual;

            tarefaAtual = new Tarefa
            {
                IdTarefas = tarefa.Id,
                Nome = tarefa.Nome,
                Dificuldade = tarefa.Dificuldade,
                Acertou = "Não",
                Tentativas = 0,
                Imagem = tarefa.Imagem,
                Quando = DateTime.Now.ToString("dd / MM HH: mm")

        };

            _db.InsertTarefa(tarefaAtual);

            tarefaAtual = _db.GetTarefa();
        }

        private void ApertouAction(object sender, EventArgs args)
        {
            Button escolha = (Button)sender;
            if (escolha.Text == jogadaatual.Nome)
                Acertou(escolha.Text);
            else
                Errou(escolha.Text);
        }

        private async void Acertou(string escolha)
        {
            tarefaAtual.Tentativas++;
            tarefaAtual.Acertou = "Sim";

            _db.UpdateTarefa(tarefaAtual);

            await DisplayAlert(escolha, "Acertou", "Ok");
            await Navigation.PopAsync();
        }

        private void Errou(string escolha)
        {
            tarefaAtual.Tentativas++;

            _db.UpdateTarefa(tarefaAtual);

            DisplayAlert(escolha, "Tentar novamente", "Ok");
        }

        public class JogoOpcoes
        {
            public int Id{ get; set; }
            public string Nome{ get; set; }
            public int Dificuldade { get; set; }
            public string Imagem{ get; set; }
            public string Nome01 { get; set; }
            public string Nome02 { get; set; }
            public string Nome03 { get; set; }
            public string Nome04 { get; set; }
            private int botaoCerto { get; set; }

            Random rand = new Random();
            public const string Alphabet = "abcdefghijklmnopqrstuvwyxzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";


            public JogoOpcoes(Tarefas tarefa)
            {
                botaoCerto = rand.Next(1, 4);
                Id = tarefa.Id;
                Nome = tarefa.Nome;
                Dificuldade = tarefa.Dificuldade;
                Imagem = tarefa.Imagem;
                Nome01 = GerarNomes(1);
                Nome02 = GerarNomes(2);
                Nome03 = GerarNomes(3);
                Nome04 = GerarNomes(4);
            }

            private string GerarNomes(int posicao)
            {
                if (posicao == botaoCerto)
                    return Nome;
                else
                    return GerarNomeZuado(rand.Next(5, 10));
            }

            public string GerarNomeZuado(int size)
            {
                char[] chars = new char[size];
                for (int i = 0; i < size; i++)
                {
                    chars[i] = Alphabet[rand.Next(Alphabet.Length)];
                }
                return new string(chars);
            }
        }
    }
}