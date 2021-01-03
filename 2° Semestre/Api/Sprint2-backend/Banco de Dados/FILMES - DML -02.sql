USE Filmes_manha;

SELECT * FROM Generos

INSERT INTO Generos (Nome)
VALUES				( ' Ação ' )
					, ( ' Drama ' );
					
INSERT INTO Filmes (Titulo, IdGenero)
VALUES 				( ' A vida é bela ' , 2 )
					, (  'Rambo' , 1 );