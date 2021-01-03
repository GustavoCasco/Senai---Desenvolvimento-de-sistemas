
CREATE DATABASE Pclinics;
USE Pclinics;

--CRIAR TABELA--
CREATE TABLE Dono (
IdPessoas INT PRIMARY KEY IDENTITY, 
Nome     VARCHAR (200)
);

CREATE TABLE TipoPet (
IdTipoPet    INT PRIMARY KEY IDENTITY,
NomeTipoPet      VARCHAR (200)
);

CREATE TABLE Clinica (
IdClinica    INT PRIMARY KEY IDENTITY,
RazaoSocial  VARCHAR (200),
Endereco     VARCHAR (200)
);

CREATE TABLE Raca (
IdRaca       INT PRIMARY KEY IDENTITY,
NomeRaca     VARCHAR (200),
IdTipoPet    INT FOREIGN KEY REFERENCES TipoPet (IdTipoPet)
);

CREATE TABLE Pet (
IdPet        INT PRIMARY KEY IDENTITY,
Nome         VARCHAR (200),
Telefone     VARCHAR (200),
IdDono       INT FOREIGN KEY REFERENCES Dono (IdPessoas),
IdRaca       INT FOREIGN KEY REFERENCES Raca (IdRaca)
);


CREATE TABLE Veterinario (
IdVeterinario  INT PRIMARY KEY IDENTITY,
Nome           VARCHAR (200),
Crmv           VARCHAR (200),
IdClinica      INT FOREIGN KEY REFERENCES Clinica (IdClinica)
);

CREATE TABLE Atendimento (
IdAtendimento    INT PRIMARY KEY IDENTITY,
DiaConsulta         VARCHAR (200),
Descricao        VARCHAR (200),
IdVeterinario    INT FOREIGN KEY REFERENCES Veterinario (IdVeterinario),
IdPet            INT FOREIGN KEY REFERENCES Pet         (IdPet)
);



