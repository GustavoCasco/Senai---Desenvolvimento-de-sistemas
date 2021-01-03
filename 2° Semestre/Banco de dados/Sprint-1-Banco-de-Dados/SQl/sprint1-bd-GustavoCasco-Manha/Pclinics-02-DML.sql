INSERT INTO Dono (Nome)
VALUES      ('Alberto'),
            ('Carlos');

INSERT INTO Clinica (RazaoSocial , Endereco)
VALUES              ('Pclinics' , 'Alameda Barao de Limeira'),
                    ('Pclinics' , 'Rua do trabalho');

INSERT INTO TipoPet (NomeTipoPet)
VALUES      ('Cachorro'),
            ('Gato');

INSERT INTO Veterinario (Nome , Crmv , IdClinica)
VALUES                  ('Isabella' , ' 0521', 1),
                        ('Larissa'  ,  '2544', 2);

INSERT INTO Raca (NomeRaca , IdTipoPet)
VALUES           ('PITBULL', 1),
                 ('Siames', 2);


INSERT INTO Pet (Nome , Telefone, IdDono,  IdRaca)
VALUES          ('Flock' , '970707070', 1, 2),
                ('Miau'  , '40028922', 2, 1);

INSERT INTO Atendimento (DiaConsulta , Descricao, IdPet, IdVeterinario)
VALUES                  ('20/08/2020', ' ', 1 , 2),
                        ('29/09/2020', ' ', 2 , 1);
