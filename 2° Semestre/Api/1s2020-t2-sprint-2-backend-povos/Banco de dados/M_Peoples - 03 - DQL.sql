SELECT Cadastro.Nome, Cadastro.Sobrenome FROM Cadastro

SELECT Usuario.Nome , Usuario.Email, TipoUsuario.TipoUsuario  FROM Usuario
INNER JOIN TipoUsuario ON Usuario.IdTipoUsuario = TipoUsuario.IdTipoUsuario

select * from Usuario WHERE IdTipoUsuario = 2 
