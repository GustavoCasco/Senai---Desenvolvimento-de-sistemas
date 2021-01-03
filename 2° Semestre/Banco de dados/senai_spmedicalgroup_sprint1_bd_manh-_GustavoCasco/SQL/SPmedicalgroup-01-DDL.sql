CREATE DATABASE SpMedicalGroup_manha

CREATE TABLE Clinica (
IdClinica     INT PRIMARY KEY IDENTITY,
Razao_Social  VARCHAR(200),
Endereco      VARCHAR(200),
Numero        INT,
CNPJ          CHAR(14)
);
GO

CREATE TABLE TipoUsuario (
IdTipoUsuario  INT PRIMARY KEY IDENTITY,
TipoUsuario    VARCHAR(200)
);
GO

CREATE TABLE Especialidade (
IdEspecialidade  INT PRIMARY KEY IDENTITY,
Especialidade    VARCHAR(200)
);
GO

CREATE TABLE Medico (
IdMedico      INT PRIMARY KEY IDENTITY,
NomeMedico    VARCHAR(200),
CRM           VARCHAR(200),
EMAIL         VARCHAR(200),
IdClinica     INT FOREIGN KEY REFERENCES Clinica (IdClinica),
IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade (IdEspecialidade),
IdTipoUsuario  INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);
GO

CREATE TABLE Usuario (
IdUsuario     INT PRIMARY KEY IDENTITY,
Nome          VARCHAR (200),
Email         VARCHAR (200),
Senha         VARCHAR (200),
DataNascimento DATETIME2,
Telefone      VARCHAR(200),
RG            CHAR(9),
CPF           CHAR(11),
Endereco      VARCHAR(200),
Numero        INT,
IdTipoUsuario  INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario)
);
GO

CREATE TABLE Consulta (
IdConsulta INT PRIMARY KEY IDENTITY,
DataConsulta  DATETIME2,
Situacao      VARCHAR(200),
IdMedico      INT FOREIGN KEY REFERENCES Medico (IdMedico),
IdUsuario     INT FOREIGN KEY REFERENCES Usuario (IdUsuario)
);
GO


