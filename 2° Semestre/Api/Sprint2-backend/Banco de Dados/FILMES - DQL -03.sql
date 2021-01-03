
SELECT  *  FROM Generos;
SELECT  *  FROM Filmes;

SELECT IdGenero, Nome FROM Generos;

SELECT  Filmes.Titulo, Generos.Nome FROM Generos 
INNER JOIN Filmes ON Generos.IdGenero = Filmes.IdGenero;