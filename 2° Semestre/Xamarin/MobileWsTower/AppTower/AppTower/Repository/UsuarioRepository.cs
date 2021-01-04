using AppTower.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppTower.Repository
{
    public class UsuarioRepository
    {
        readonly SQLiteAsyncConnection _database;

        public UsuarioRepository(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Usuario>().Wait();
        }

        public Task<List<Usuario>> GetUsuarioAsync()
        {
            return _database.Table<Usuario>().ToListAsync();
        }

        public Task<int> SaveUsuarioAsync(Usuario usuario)
        {
            return _database.InsertAsync(usuario);
        }
    }
}
