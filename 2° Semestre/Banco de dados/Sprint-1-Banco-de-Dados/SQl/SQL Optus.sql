CREATE DATABASE Optus;
Use Optus;

CREATE TABLE TipoUsuario (
IdTipoUser INT PRIMARY KEY IDENTITY ,
Nome       VARCHAR (200) NOT NULL
);

CREATE TABLE Artista (
IdArtista INT PRIMARY KEY IDENTITY ,
Nome      VARCHAR (200) NOT NULL
);

CREATE TABLE Estilos (
IdEstilo INT PRIMARY KEY IDENTITY , 
Nome      VARCHAR (200)
);

CREATE TABLE Usuario (
IdUsuario INT PRIMARY KEY IDENTITY , 
Nome      VARCHAR (200) ,
IdTipoUser INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUser)
);
DROP TABLE Estilos
CREATE TABLE Albuns (
IdAlbuns INT PRIMARY KEY IDENTITY ,
Nome     VARCHAR (200) NOT NULL ,
DataLançamento DATE ,
QndMinutos VARCHAR (200),
Visualização VARCHAR (200) , 
IdArtista INT FOREIGN KEY REFERENCES Artista (IdArtista),
IdEstilo  INT FOREIGN KEY REFERENCES Estilos (IdEstilos)
);

--ALTERAÇÃO NA COLUNA
ALTER TABLE Albuns
ALTER COLUMN DataLançamento DATE;

-- DML INSERIR
--iNSERIR DADODS
INSERT INTO TipoUsuario (Nome)
VALUES     ('ADMINISTRADOR'),
           ('COMUM'),
		   ('LOJISTA'),
		   ('COMPRADOR'),
		   ('VISITANTE');

INSERT INTO Estilos (Nome)
VALUES     ('FUNK'),
           ('PAGODE'),
		   ('ROCK'),
		   ('SAMBA'),
		   ('AXÉ');

INSERT INTO Artista (Nome)
VALUES     ('Mc Lon'),
           ('Pericles'),
		   ('Pitty'),
		   ('Zeca Pagodinho'),
		   ('Baroes da Pisadinha');

INSERT INTO Usuario (Nome , IdTipoUser)
VALUES     ('Gustavo' , 4),
           ('Carlos' , 5),
		   ('Vitor' , 2),
		   ('Isabella' , 1),
		   ('Fernanda' , 3);

INSERT INTO Albuns (Nome , DataLançamento , QndMinutos , Visualização , IdArtista, IdEstilo)
VALUES     ('Sou filho da lua' , '01/08/2020' , '75 minutos', '90 mi', 1 , 1),
           ('Feito para durar' , '02/08/2020' ,'90 minutos' , '10 mi', 2 ,2),
		   ('Matriz' , '10/08/2020' , '30 minutos', '20 mi', 3 , 3),
		   ('Ao vivo' , '20/08/2020' , '120 minutos' , '30 mi', 4 , 4),
		   ('Batom de Ouro' , '20/08/2020' , '60 minutos' , '15 mi', 5 , 5);

INSERT INTO Artista (Nome)
VALUES     ('Mc Dede');

INSERT INTO Albuns (Nome , DataLançamento , QndMinutos , Visualização , IdArtista, IdEstilo)
VALUES     ('Funk' , '31/08/2020' , '75 minutos', '90 mi', 1 , 1);
           

truncate table Albuns

--ALTERAÇÃO
UPDATE Artista
SET  Nome = 'Mc Daleste'
WHERE IdArtista = 1;

UPDATE TipoUsuario
SET  Nome = 'Hebert Richard'
WHERE IdTipoUser = 1;

UPDATE Albuns
SET  QndMinutos = '1004 minutos'
WHERE IdAlbuns BETWEEN 4 AND 1;

-- Apagar um album
DELETE FROM Albuns
WHERE IdAlbuns = 3;

DELETE FROM Albuns
WHERE IdAlbuns = 10;

-- Apagar um CANTOR
DELETE FROM Artista
WHERE IdArtista = 8;

DELETE FROM Albuns
WHERE IdAlbuns BETWEEN 3 AND 5;



-- DQL
SELECT * FROM Albuns;
SELECT * FROM Usuario;
SELECT * FROM Estilos;
SELECT * FROM Artista;
SELECT * FROM TipoUsuario;


--Seleção dos albuns do mesmo artista
SELECT * FROM Albuns WHERE IdArtista = 1;

--Seleção dos albuns do mesmo artista com INNER JOIN
SELECT * FROM Artista INNER JOIN Albuns ON Artista.IdArtista = Albuns.IdArtista
WHERE Albuns.IdArtista = 1;

--Seleção dos albuns com as mesma data de lançamento
SELECT * FROM Albuns  WHERE DataLançamento = '2020/08/31';

--Seleção dos albuns com as mesma data de lançamento com INNER JOIN 
SELECT * FROM Artista INNER JOIN Albuns ON Artista.IdArtista = Albuns.IdArtista
WHERE  DataLançamento = '2020/08/20';


--Seleção do artista do mesmo estilo
SELECT Artista.Nome, Estilos.Nome FROM Artista 
INNER JOIN Albuns ON Artista.IdArtista = Albuns.IdArtista 
INNER JOIN Estilos ON Artista.IdArtista = Estilos.IdEstilos
WHERE Estilos.IdEstilos = 1;

-- Seleção e ordenar 
SELECT IdAlbuns, IdArtista, DataLançamento FROM Albuns
ORDER BY DataLançamento DESC; 


--Seleção com INNER JOIN

SELECT * FROM Albuns INNER JOIN Artista ON Albuns.IdArtista = Artista.IdArtista
ORDER BY DataLançamento DESC;







