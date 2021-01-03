SELECT Nome FROM Dono;

SELECT NomeTipoPet FROM TipoPet;

SELECT RazaoSocial , Endereco FROM Clinica;

SELECT Veterinario.Nome, Veterinario.Crmv, Clinica.RazaoSocial FROM Veterinario 
INNER JOIN Clinica ON Veterinario.IdClinica = Clinica.IdClinica;

SELECT Raca.NomeRaca, TipoPet.NomeTipoPet FROM Raca 
INNER JOIN TipoPet ON Raca.IdTipoPet = TipoPet.IdTipoPet;

SELECT Pet.Nome , Pet.Telefone , Dono.Nome , Raca.NomeRaca FROM Pet
INNER JOIN Dono ON Pet.IdDono = Dono.IdPessoas
inner join Raca ON Pet.IdRaca = Raca.IdRaca

SELECT  Raca.NomeRaca FROM Raca

SELECT Veterinario.Nome, Atendimento.DiaConsulta, Atendimento.Descricao, Pet.Nome FROM Atendimento
INNER JOIN Pet ON Atendimento.IdPet = Pet.IdPet
INNER JOIN Veterinario ON Atendimento.IdVeterinario = Veterinario.IdVeterinario

