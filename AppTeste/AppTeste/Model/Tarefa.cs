using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppTeste.Model
{
    public class Tarefa
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}
