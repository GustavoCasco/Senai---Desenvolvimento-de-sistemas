SELECT Nome FROM Artista;

--OPERAÇOES < > = 
SELECT * FROM Albuns WHERE IdAlbuns = 1;
SELECT * FROM Albuns WHERE IdAlbuns > 1;

--> OR OU 
SELECT Nome  , QndMinutos FROM Albuns
WHERE (DataLançamento IS NULL) OR (Visualização IS NULL);


--> FILTRO DE TEXTO (LIKE)
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE 'Mc Daleste%'; 
--> sds% serve para o final da frase <--

--> %sds serve para começo da frase <--
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE '%Mc Daleste'; 

--> %sds% serve para quando tem palavras na frente e após a frase <--
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE '%Mc Daleste%'; 
-------------------------------

-- ORDENACAO

SELECT IdAlbuns, Nome, QndMinutos, Visualização FROM Albuns
ORDER BY QndMinutos, Visualização;

-- ORDENACAO DECRESCENTE
SELECT IdAlbuns, Nome, QndMinutos, Visualização FROM Albuns
ORDER BY QndMinutos, Visualização DESC;

-- ORDENACAO CRESCENTE
SELECT IdAlbuns, Nome, QndMinutos, Visualização FROM Albuns
ORDER BY QndMinutos, Visualização ASC;


-- COUNT 
SELECT COUNT(IdAlbuns) FROM Albuns;