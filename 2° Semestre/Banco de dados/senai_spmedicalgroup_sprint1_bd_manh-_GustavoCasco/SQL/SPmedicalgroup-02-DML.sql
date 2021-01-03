INSERT INTO Clinica (Razao_Social, Endereco, Numero, CNPJ, HorarioAbre, HorarioFecha)
VALUES              ('SpMedicalGroup', 'Avenida Alameda Barao de Limeira', 495, '90909090909090', '08:00', '16:00');
truncate table clinica
INSERT INTO TipoUsuario (TipoUsuario)
VALUES                  ('Adm'),
						('Paciente'),
						('Medico');

INSERT INTO Especialidade (Especialidade)
VALUES                    ('Psiquiatra'),	
						  ('Psicologia'),
						  ('Pediatra'),
						  ('Cardiologista'),
						  ('Toc'),
						  ('Dermatologista'),
						  ('Urologista'),
						  ('otorrinolaringologia'),
						  ('Acunputura'),
						  ('Cirurgia Geral');

INSERT INTO Usuario       (Nome, DataNascimento, RG, CPF, Email, Senha, Endereco, Numero, Telefone, IdTipoUsuario)
VALUES                    ('Gustavo Casco', '31/08/2001', '909090909', '12345456009', 'gustavo@gustavo.com', 'gustavo123', 'rua do trabalho', '327', '909099090', 1),
						  ('Carlos Morette', '11/08/1998', '707070707', '90654545321', 'Carlos@Carlos.com',' carlos123','rua gregorio souza', '327', '909099090', 1),
						  ('Joao Vitor',' 22/04/1997', '808080808', '45454545450', 'joao@joao.com', 'joao123','rua felipe salomao', '707', '909099090', 2),
						  ('Gabrielle',' 01/09/2001', '123456765', '09090909990', 'Gabrielle@Gabrielle.com', 'gabrielle123','Rua alameda barao de limeira', '807', '909099090', 2);

INSERT INTO Medico       (NomeMedico, Email, Senha, CRM, IdEspecialidade, IdClinica, IdTipoUsuario)
VALUES                   ('Tilambuco', 'tilambuco@tilambuco.com','tilambuco123 ','54356', 2, 1,3),
						 ('Helena Strada', 'helana@helena', 'helena123', '53452',  9 ,1,3),
						 ('Ricardo Lemos', 'ricardo@ricardo.com','Ricardo123','65463',5,1,3);

INSERT INTO Consulta     (DataConsulta, Situacao, IdMedico, IdUsuario)
VALUES                   ('11/02/2020 12:30', 'Confirmado', 1, 1),
						 ('14/02/2020 14:30', 'Nao Confirmado', 3, 2),
						 ('22/02/2020 15:30', 'Confirmado', 2 , 3);

SELECT * FROM Clinica
SELECT * FROM Consulta
SELECT * FROM Medico
SELECT * FROM Usuario
SELECT * FROM TipoUsuario
SELECT * FROM Especialidade


