using System;
using System.Collections.Generic;
using System.Text;
using AppTeste.Model;
using SQLite;
using Xamarin.Forms;

namespace AppTeste.Database
{
    public class TarefasDataAcess
    {
        private SQLiteConnection _database;

        public TarefasDataAcess()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }

        public List<Tarefa> GetTarefas()
        {
            return _database.Table<Tarefa>().ToList();
        }

        public int SalvarTarefa(Tarefa tarefa)
        {
            return _database.Insert(tarefa);
        }
    }
}
