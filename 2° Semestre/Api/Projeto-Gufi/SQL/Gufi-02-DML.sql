INSERT INTO TipoUsuario (TipoUsuario)
VALUES                  ('Administrador'),
						('Comum');

INSERT INTO TipoEvento (TipoEvento)
VALUES				   ('C#'),
					   ('React'),
					   ('SQL');

INSERT INTO Usuario (NomeUsuario, Email, Senha, DataCadastrado, Genero, IdTipoUsuario)
VALUES				('Administrador', 'adm@adm.com', '123adm', '06/02/2020', 'Não Informado', '1'),
					('Carol', 'carol@carol.com', '123carol', '08/03/2020', 'Feminino', '2'),
					('Saulo', 'Saulo@saulo.com' , '123saulo', '10/02/2020', 'Masculino', '2');

INSERT INTO Eventos (NomeEvento, Privacidade, DataEvento, Descricao, IdTipoEvento, IdInstituicao)
VALUES              ('POO', ' 1', '06/02/2020', 'Evento maneiro', 1, 1),
					('Ciclo de vida' , '0 ', '07/02/2020', 'Evento Show de bola', 2, 1),
					('SQL', ' 1' , '08/02/2020', 'Evento show', 3, 1);

INSERT INTO Instituicao (CNPJ, NomeFantasia ,Endereco)
VALUES					('90909090909090', 'escola SENAI de informatica', 'Alameda Barao de Limeira');

INSERT INTO Presenca (Situacao, IdEvento, IdUsuario)
VALUES               ('Confirmado', 2, 1),
					 ('Nao confirmado', 3, 2),
					 ('Confirmado', 4, 3);

DELETE FROM Presenca
WHERE IdEventos = 3;

TRUNCATE TABLE Eventos;
TRUNCATE TABLE Presenca

DELETE FROM Eventos
WHERE IdEventos IN (5,6,7);

SELECT * FROM Usuario
SELECT * FROM Instituicao;
SELECT * FROM Eventos;
SELECT * FROM Usuario;
SELECT * FROM TipoEvento;
SELECT * FROM TipoUsuario;
SELECT * FROM Presenca;

