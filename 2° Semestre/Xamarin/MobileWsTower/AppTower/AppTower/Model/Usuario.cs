using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTower.Model
{
   public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string User { get; set; }
        public string Apelido { get; set; }
        public string Senha { get; set; }
    }
}
