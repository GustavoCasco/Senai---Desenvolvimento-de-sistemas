using senai.Filmes.WebApi.Domains;
using senai.Filmes.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Repositories
{
    public class FilmeRepository : IFilmeRepositiory

    {

      private string stringconexao = "Data Source = DESKTOP - GCOFA7F\\SQLEXPRESS; initial catalog = Filmes_manha; user Id = sa; pwd=sa@132";


        public void AtualizarCorpo(FilmeDomain filmesnovos)
        {
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string queryAtualizar = "UPDATE Filme SET Titulo = @Titulo WHERE IdFilme = @ID";

                using (SqlCommand cmd = new SqlCommand(queryAtualizar, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", filmesnovos.Titulo);

                    cmd.Parameters.AddWithValue("@ID", filmesnovos.IdFilme);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            
        }

        

        public void AtualizarUrl(int id, FilmeDomain filmesnovos)
        {
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
            string queryURL = "UPDATE Filme SET Titulo = @Titulo WHERE IdFilme = @ID";

            using (SqlCommand cmd = new SqlCommand(queryURL, con))
            {
                    cmd.Parameters.AddWithValue("@Titulo", filmesnovos.Titulo);

                    cmd.Parameters.AddWithValue("@ID", filmesnovos.IdFilme);
            }

            }
            
        }

     

        public FilmeDomain BuscarporId(FilmeDomain filmenovo, int id)
        {
            List<FilmeDomain> filme = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string querryler = "SELECT Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero = Genero.IdGenero = @ID";

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querryler, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    rdr = cmd.ExecuteReader();

                    con.Open();

                    while (rdr.Read())
                    {
                        FilmeDomain film = new FilmeDomain
                        {
                            Titulo = rdr["Titulo"].ToString(),

                            IdFilme = Convert.ToInt32(rdr[0])


                        };
                        return film;
                    }
                }
            }
            return null;

        }

        public void Delete(int id)
        {
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string querydelete = "DELETE FROM Filme WHERE IdFilme = @ID";

                using (SqlCommand cmd = new SqlCommand(querydelete, con))
                {
                    cmd.Parameters.AddWithValue("@ID", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<FilmeDomain> Listar()
        {
            List<FilmeDomain> filme = new List<FilmeDomain>();

            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string querryler = "SELECT Filme.Titulo, Genero.Nome FROM Filme INNER JOIN Genero ON Filme.IdGenero = Genero.IdGenero";

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querryler, con))
                {
                    rdr = cmd.ExecuteReader();

                    con.Open();

                    while(rdr.Read())
                    {
                        FilmeDomain film = new FilmeDomain
                        {
                            Titulo = rdr ["Titulo"].ToString(),

                            IdFilme = Convert.ToInt32(rdr[0])
                            

                        };
                        filme.Add(film);
                    }
                }
            }
            return filme;
        }

        public void Cadastrar (FilmeDomain filmenovo, int id)
        {
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string queryadd = "INSERT INTO Filme (Titulo, IdGenero) VALUES (@Titulo , @IdGenero)";

                using (SqlCommand cmd = new SqlCommand(queryadd, con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", filmenovo.Titulo);

                    cmd.Parameters.AddWithValue("@IdGenero", id);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

      
    }
}
