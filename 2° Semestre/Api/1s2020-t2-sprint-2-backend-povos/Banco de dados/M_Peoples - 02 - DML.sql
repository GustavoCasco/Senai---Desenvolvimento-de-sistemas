INSERT INTO Cadastro (Nome, Sobrenome)
VALUES               ('Catarina', 'Strada'),
                     ('Tadeu', 'Vitelli');

INSERT INTO TipoUsuario (TipoUsuario)
VALUES                  ('Adm'),
						('Comum');


INSERT INTO Usuario (Nome, Email, Senha, IdTipoUsuario)
VALUES              ('Gustavo', 'guga@guga.com', '123', 2),
					('Nathalia', 'nath@nath', '123', 2),
					('Gabrielle', 'gabi@gabi', '123', 1),
					('Carlos', 'carlao@carlao', '123', 1);