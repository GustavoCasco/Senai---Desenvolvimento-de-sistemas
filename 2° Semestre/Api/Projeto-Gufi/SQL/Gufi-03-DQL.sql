SELECT Usuario.NomeUsuario, Usuario.Genero, TipoUsuario.TipoUsuario FROM Usuario
 INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario;
 
SELECT Instituicao.NomeFantasia, Instituicao.CNPJ, Instituicao.Endereco FROM Instituicao;

SELECT TipoEvento.TipoEvento FROM TipoEvento;

SELECT Eventos.NomeEvento, Eventos.Privacidade, Eventos.DataEvento, 
Eventos.Descricao, TipoEvento.TipoEvento, Instituicao.NomeFantasia  FROM Eventos 
INNER JOIN TipoEvento ON Eventos.IdTipoEvento = TipoEvento.IdTipoEvento
INNER JOIN Instituicao ON Eventos.IdInstituicao = Instituicao. IdInstituicao

SELECT Eventos.NomeEvento,
Case Privacidade when 0 then 'Restrito' when 1 then 'Livre' end as Privacidade 
, Eventos.DataEvento, 
Eventos.Descricao, TipoEvento.TipoEvento, Instituicao.NomeFantasia, Instituicao.CNPJ FROM Eventos 
INNER JOIN TipoEvento ON Eventos.IdTipoEvento = TipoEvento.IdTipoEvento
INNER JOIN Instituicao ON Eventos.IdInstituicao = Instituicao. IdInstituicao


 

SELECT Eventos.NomeEvento, Privacidade = 'LIVRE', Eventos.DataEvento, 
Eventos.Descricao, TipoEvento.TipoEvento, Instituicao.NomeFantasia, Instituicao.CNPJ, Usuario.NomeUsuario,
Usuario.Genero, TipoUsuario.TipoUsuario, Presenca.Situacao FROM Presenca 
INNER JOIN Eventos ON Eventos.IdEventos = Presenca.IdEvento
INNER JOIN TipoEvento ON TipoEvento.IdTipoEvento = Eventos.IdTipoEvento
INNER JOIN Instituicao ON Eventos.IdInstituicao = Instituicao. IdInstituicao
INNER JOIN Usuario ON Usuario.IdUsuario = Presenca.IdUsuario
INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario
WHERE (Situacao = 'Confirmado') and (Privacidade = 1);
 




