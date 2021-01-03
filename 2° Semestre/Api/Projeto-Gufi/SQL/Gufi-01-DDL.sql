--CRIACAO DO BANCO DE DADOS
CREATE DATABASE Gufi_manha;
DROP DATABASE Gufi_manha

--CRIACAO DE TABELAS
CREATE TABLE TipoUsuario (
IdTipoUsuario INT PRIMARY KEY IDENTITY,
TipoUsuario  VARCHAR (255) NOT NULL
);

CREATE TABLE TipoEvento (
IdTipoEvento  INT PRIMARY KEY IDENTITY,
TipoEvento  VARCHAR (255) NOT NULL
);

CREATE TABLE Instituicao (
IdInstituicao  INT PRIMARY KEY IDENTITY,
CNPJ           CHAR (14) NOT NULL UNIQUE,
NomeFantasia   VARCHAR (255) NOT NULL UNIQUE,
Endereco       VARCHAR (200) NOT NULL UNIQUE
);

CREATE TABLE Usuario (
IdUsuario   INT PRIMARY KEY IDENTITY,
NomeUsuario  VARCHAR (200) NOT NULL,
Email       VARCHAR (200) NOT NULL UNIQUE,
Senha       VARCHAR (200) NOT NULL,
DataCadastrado DateTime2,
Genero       VARCHAR (200),
IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);

DROP TABLE Eventos

CREATE TABLE Eventos (
IdEventos   INT PRIMARY KEY IDENTITY,
NomeEvento  VARCHAR (200) NOT NULL,
Privacidade bit,
DataEvento  DateTime,
Descricao   VARCHAR (200),
IdTipoEvento INT FOREIGN KEY REFERENCES TipoEvento (IdTipoEvento),
IdInstituicao INT FOREIGN KEY REFERENCES Instituicao (IdInstituicao)
);

CREATE TABLE Presenca (
IdPresenca   INT PRIMARY KEY IDENTITY,
Situacao     VARCHAR (200),
IdUsuario    INT FOREIGN KEY REFERENCES Usuario (IdUsuario),
IdEvento     INT FOREIGN KEY REFERENCES Eventos (IdEventos)
);

SELECT * FROM Presenca

DROP TABLE Presenca