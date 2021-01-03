CREATE DATABASE Locadora_Manha
use Locadora_Manha

CREATE TABLE Empresa (
IdEmpresa     INT PRIMARY KEY IDENTITY,
RazaoSocial   VARCHAR (200)
);

CREATE TABLE Marca (
IdMarca      INT PRIMARY KEY IDENTITY,
Nome         VARCHAR (200)
);

CREATE TABLE Modelo (
IdModelo     INT PRIMARY KEY IDENTITY,
NomeModelo   VARCHAR (200)
);

CREATE TABLE Cliente (
IdCliente  INT PRIMARY KEY IDENTITY,
NomeCliente VARCHAR (200),
CPF         VARCHAR (200)
);

CREATE TABLE Veiculo (
IdVeiculo    INT PRIMARY KEY IDENTITY,
Placa        VARCHAR (200),
IdEmpresa    INT FOREIGN KEY REFERENCES Empresa (IdEmpresa),
IdModelo     INT FOREIGN KEY REFERENCES Modelo  (IdModelo)
);

CREATE TABLE Aluguel (
IdAluguel    INT PRIMARY KEY IDENTITY,
DataInicio   VARCHAR (200),
DataFim      VARCHAR (200),
IdCliente    INT FOREIGN KEY REFERENCES Cliente (IdCliente),
IdVeiculo    INT FOREIGN KEY REFERENCES Veiculo (IdVeiculo)
);


