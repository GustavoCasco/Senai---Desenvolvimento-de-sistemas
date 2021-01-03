SELECT Nome FROM Artista;

--OPERA�OES < > = 
SELECT * FROM Albuns WHERE IdAlbuns = 1;
SELECT * FROM Albuns WHERE IdAlbuns > 1;

--> OR OU 
SELECT Nome  , QndMinutos FROM Albuns
WHERE (DataLan�amento IS NULL) OR (Visualiza��o IS NULL);


--> FILTRO DE TEXTO (LIKE)
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE 'Mc Daleste%'; 
--> sds% serve para o final da frase <--

--> %sds serve para come�o da frase <--
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE '%Mc Daleste'; 

--> %sds% serve para quando tem palavras na frente e ap�s a frase <--
SELECT IdArtista , Nome FROM Artista
WHERE Nome LIKE '%Mc Daleste%'; 
-------------------------------

-- ORDENACAO

SELECT IdAlbuns, Nome, QndMinutos, Visualiza��o FROM Albuns
ORDER BY QndMinutos, Visualiza��o;

-- ORDENACAO DECRESCENTE
SELECT IdAlbuns, Nome, QndMinutos, Visualiza��o FROM Albuns
ORDER BY QndMinutos, Visualiza��o DESC;

-- ORDENACAO CRESCENTE
SELECT IdAlbuns, Nome, QndMinutos, Visualiza��o FROM Albuns
ORDER BY QndMinutos, Visualiza��o ASC;


-- COUNT 
SELECT COUNT(IdAlbuns) FROM Albuns;