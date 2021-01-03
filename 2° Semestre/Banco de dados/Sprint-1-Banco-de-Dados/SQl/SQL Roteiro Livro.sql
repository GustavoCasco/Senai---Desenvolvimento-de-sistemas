-- Comando Criar Banco de dados-- 
-- DDl Linguagem de DEFINIÇÃO DE DADOS --
CREATE DATABASE RoteiroLivro;
Use RoteiroLivro;

CREATE TABLE Generos (
IdGenero INT PRIMARY KEY IDENTITY ,
Nome     VARCHAR(200) NOT NULL
);

CREATE TABLE Autores (
IdAutor  INT PRIMARY KEY IDENTITY ,
NomeAutor VARCHAR(200)
);

CREATE TABLE Livros (
IdLivros INT PRIMARY KEY IDENTITY , 
Titulo   VARCHAR (255),
IdGenero INT FOREIGN KEY REFERENCES Generos (IdGenero), 
IdAutor  INT FOREIGN KEY REFERENCES Autores (IdAutor)
);


-- DML INSERIR DADOS
INSERT INTO Generos (Nome)
VALUES ('ACAO'),
       ('TERROR'),
	   ('DRAMA'),
	   ('SUSPENSE'),
	   ('ESPIRITA');

INSERT INTO Autores (NomeAutor)
VALUES ('Paulo Coelho'),
       ('Vinicius de Moraes'),
	   ('Monteiro Lobato'),
	   ('John Gren'),
	   ('Ruth Rocha');

INSERT INTO Livros (Titulo , IdAutor, IdGenero)
VALUES ('Frases', 1 , 2),
       ('Arca de Noé', 2 , 3),
	   ('Picapau Amarelo', 3, 4),
	   ('A Culpa é das Estrelas', 4, 1),
	   ('Borba, o Gato', 5, 2);

INSERT INTO Autores (NomeAutor)
VALUES ('Hebert Richard');
      



--ALteraçao de Genero
UPDATE Generos
SET Nome = 'Biografia'
Where Nome = 'TERROR';

-- Apagar autor
DELETE FROM Autores
WHERE IdAutor = 6;



-- DQL comando de consulta--

SELECT * FROM Autores;
SELECT * FROM Generos;
SELECT * FROM Livros;


--seleção de Autores
SELECT NomeAutor, IdAutor From Autores;

--SELEÇAO DE Genero
SELECT Nome, IdGenero FROM Generos;

--SELEÇÃO DE LIVROS
SELECT Titulo, IdLivros FROM Livros;

--Selecionar os livros e autores
SELECT * FROM Livros
WHERE (IdLivros = 2) and (IdAutor = 2);

--Selecionar Livros e generos
SELECT * FROM Livros
WHERE  (IdLivros = 1) and (IdGenero = 2);

--Selecionar Livros e autores e generos
SELECT * FROM Livros
WHERE  (IdLivros = 2) and (IdGenero = 3) and (IdAutor = 2);



