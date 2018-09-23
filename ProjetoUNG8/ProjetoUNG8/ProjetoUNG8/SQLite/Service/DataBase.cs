using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;
using Xamarin.Forms;
using ProjetoUNG8.SQLite.Models;

namespace ProjetoUNG8.SQLite.Service
{
    public class DataBase
    {
        private SQLiteConnection _db;
        public DataBase()
        {
            var dep = DependencyService.Get<ICaminho>();
            string path = dep.ObterCaminho("Projeto004.sqlite");

            _db = new SQLiteConnection(path);
            _db.CreateTable<Tarefas>();
            _db.CreateTable<Tarefa>();
        }

        //---------------------------------------------
        //-----------------TAREFAS---------------------
        //---------------------------------------------
        public List<Tarefas> GetAllTarefas()
        {
            //INICIO DO MACHINE LEARNING VAI SER AQUI, PARA PEGAR DEVO PRIMEIRO OLHAR TUDO QUE PEGUEI E SIM DEVOLVER UMA LISTA

            return _db.Table<Tarefas>().ToList();
        }

        //---------------------------------------------
        //-----------------TAREFA----------------------
        //---------------------------------------------
        public List<Tarefa> GetAllTarefa()
        {
            return _db.Table<Tarefa>().OrderByDescending(a => a.Id).ToList();
        }

        public Tarefa GetTarefa()
        {
            return _db.Table<Tarefa>().LastOrDefault();
        }

        public void InsertTarefa(Tarefa nova)
        {
            _db.Insert(nova);
        }

        public void UpdateTarefa(Tarefa nova)
        {
            _db.Update(nova);
        }

        public void CriarBase()
        {
            _db.Insert(new Tarefas
            {
                Nome = "Cavalo",
                Dificuldade = 2,
                Imagem = "Cavalo01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Carro",
                Dificuldade = 1,
                Imagem = "Carro01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Escova de dentes",
                Dificuldade = 1,
                Imagem = "EscovaDente01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Vaca",
                Dificuldade = 2,
                Imagem = "Vaca01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Água",
                Dificuldade = 1,
                Imagem = "Agua01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Areia",
                Dificuldade = 3,
                Imagem = "Areia01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Árvore",
                Dificuldade = 1,
                Imagem = "Arvore01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Cachorro",
                Dificuldade = 1,
                Imagem = "Cachorro01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Cadeira",
                Dificuldade = 1,
                Imagem = "Cadeira01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Cama",
                Dificuldade = 1,
                Imagem = "Cama01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Chuveiro",
                Dificuldade = 2,
                Imagem = "Chuveiro01.jpg"
            });
            
            _db.Insert(new Tarefas
            {
                Nome = "Gato",
                Dificuldade = 1,
                Imagem = "Gato01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Janela",
                Dificuldade = 2,
                Imagem = "Janela01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Lâmpada",
                Dificuldade = 3,
                Imagem = "Lampada01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Lápis",
                Dificuldade = 1,
                Imagem = "Lapis01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Lua",
                Dificuldade = 4,
                Imagem = "Lua01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Papel Higiênico",
                Dificuldade = 2,
                Imagem = "PapelHigienico.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Passarinho",
                Dificuldade = 2,
                Imagem = "Passarinho01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Pedras",
                Dificuldade = 3,
                Imagem = "Pedras01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Peixe",
                Dificuldade = 2,
                Imagem = "Peixe01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Porta",
                Dificuldade = 1,
                Imagem = "Porta01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Prédio",
                Dificuldade = 3,
                Imagem = "Predio01.jpg"
            });
            
            _db.Insert(new Tarefas
            {
                Nome = "Sabonete",
                Dificuldade = 1,
                Imagem = "Sabonete.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Sofá",
                Dificuldade = 2,
                Imagem = "Sofa01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Sol",
                Dificuldade = 3,
                Imagem = "Sol01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Television",
                Dificuldade = 1,
                Imagem = "Television.png"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Terra",
                Dificuldade = 5,
                Imagem = "Terra01.jpg"
            });
            
            _db.Insert(new Tarefas
            {
                Nome = "Torneira",
                Dificuldade = 1,
                Imagem = "Torneira01.jpg"
            });

            _db.Insert(new Tarefas
            {
                Nome = "Vaso Sanitário",
                Dificuldade = 1,
                Imagem = "VasoSanitario01.jpg"
            });

        }
    }
}
