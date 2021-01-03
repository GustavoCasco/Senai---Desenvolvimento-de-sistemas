SELECT * FROM Clinica
SELECT * FROM Consulta
SELECT * FROM Medico
SELECT * FROM Usuario
SELECT * FROM TipoUsuario
SELECT * FROM Especialidade

SELECT Consulta.DataConsulta, Consulta.Situacao, Medico.NomeMedico, Usuario.Nome FROM Consulta
INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Usuario ON Consulta.IdUsuario = Usuario.IdUsuario

SELECT Medico.NomeMedico, Medico.CRM, Medico.EMAIL, Medico.Senha, Clinica.Razao_Social, Especialidade.Especialidade, TipoUsuario.TipoUsuario FROM Medico
INNER JOIN Clinica ON Medico.IdClinica = Clinica.IdClinica
INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade
INNER JOIN TipoUsuario ON Medico.IdTipoUsuario = TipoUsuario.IdTipoUsuario

SELECT Usuario.Nome, Usuario.Email, Usuario.Senha, Usuario.Senha, Usuario.DataNascimento, Usuario.Telefone, Usuario.RG, Usuario.CPF, Usuario.Endereco, Usuario.Numero, TipoUsuario.TipoUsuario FROM Usuario
INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario

--Converter DATA DE NASCIMETO EM (MM/DD/YYYY)
SELECT CONVERT(VARCHAR(10), DataNascimento, 110) AS [MM/DD/YYYY]
FROM Usuario

--Contar o total de usuarios
SELECT COUNT(IdUsuario) FROM Usuario

--PROC PARA CONSULTAR OS MEDICOS PARA CADA ESPECIALIDADE
CREATE PROC MedicoEspecialidade 
@ID INT
AS

SELECT Medico.NomeMedico, Especialidade.Especialidade  FROM Medico
INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade
WHERE Especialidade.IdEspecialidade = @ID

EXECUTE MedicoEspecialidade 9

--Proc para calcular a idade do usuario
DROP PROC IdadeUsuario
CREATE PROC IdadeUsuario 
@id INT
AS
SELECT YEAR(GETDATE())-YEAR(DataNascimento)-IIF(MONTH(GETDATE())*32+DAY(GETDATE())<MONTH(DataNascimento)*32+DAY(DataNascimento),1,0) 
FROM Usuario
WHERE Usuario.IdUsuario = @id

EXECUTE IdadeUsuario  1


