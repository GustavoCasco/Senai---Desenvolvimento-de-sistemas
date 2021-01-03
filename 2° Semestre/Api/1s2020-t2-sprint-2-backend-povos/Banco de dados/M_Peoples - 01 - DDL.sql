CREATE DATABASE M_Peoples
USE M_Peoples

CREATE TABLE Cadastro (
IdCadastro INT PRIMARY KEY IDENTITY,
Nome       VARCHAR (200) NOT NULL,
Sobrenome  VARCHAR (200) NOT NULL
);

CREATE TABLE TipoUsuario (
IdTipoUsuario      INT PRIMARY KEY IDENTITY,
TipoUsuario        VARCHAR (200)
);


CREATE TABLE Usuario (
IdUsuario         INT PRIMARY KEY IDENTITY,
Nome              VARCHAR (200) NOT NULL,
Email             VARCHAR (200) NOT NULL,
Senha             VARCHAR (200) NOT NULL,
IdTipoUsuario     INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario) 
);
