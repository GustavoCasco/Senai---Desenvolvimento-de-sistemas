CREATE DATABASE EstilosMusicais;
USE EstilosMusicais;

CREATE TABLE Estilos (
IdEstiloMusical INT PRIMARY KEY IDENTITY ,
Nome            VARCHAR(200) NOT NULL
);

CREATE TABLE Artista (
IdArtista INT PRIMARY KEY IDENTITY ,
Nome      VARCHAR (200) NOT NULL,
IdEstilo  INT FOREIGN KEY REFERENCES Estilos (IdEstiloMusical)
);

--Alterar Adicionar Novo
ALTER TABLE Estilos
ADD Descricao VARCHAR (200);



-- DML LINGUAGEM DE MANIPULACAO DE DADOS --

-- COMANDO DE INSERIR DADOS--

INSERT INTO Estilos (Nome, Descricao)
VALUES ('PAGODE','Musica DE QUALIDADE'),
       ('JAZZ' , 'Estilo Top'),
	   ('Pop' , 'Estilo Populae');

INSERT INTO Artista (Nome, IdEstilo)
VALUES ('Mc Lon' , 1),
       ('ExaltaSamba', 2),
	   ('Frank' , 3),
	   ('Rihana', 4);

-- UPDATE ALTERAR DADOS DE DENTRO DA TABELA --
UPDATE Artista
SET Nome = 'Pericles'
WHERE IdArtista = 2;

UPDATE Artista
SET IdEstilo = 1
WHERE IdArtista =2;

UPDATE Artista
SET IdEstilo = 1
WHERE IdArtista =1;

-- DELETE APAGAR DADOS NA TABELA
DELETE FROM Artista	
WHERE IdArtista = 3;


-- DQL CONSULTA DE DADOS
SELECT * FROM Estilos;
SELECT * FROM Artista;