CRIAR  BANCO  DE DADOS Filmes_manha ;
CREATE DATABASE Filmes_manha
USE Filmes_manha;

CREATE  TABLE  Generos (
	IdGenero    INT IDENTITY PRIMARY KEY
	, Nome		 VARCHAR ( 255 ) NOT NULL UNIQUE
);

CREATE  TABLE  Filmes (
	IdFilme		     INT IDENTITY PRIMARY KEY  
	, Titulo		 VARCHAR ( 255 ) NOT NULL UNIQUE
	, IdGenero	     INT FOREIGN KEY REFERENCES  Generos (IdGenero) 
);