//Fazer a integração com a API com o FETCH
async function getFilmes() {
    try {
        //Chamando a URL da API no qual vai ser consumida
        const url = "http://localhost:5000/api/filmes"
        const request = await fetch(url)
        const response = await request.json()
        return response
    } catch (error) {
        throw new Error(error)
    }
}

async function renderFilmes() {
    try {

        const filmes = await getFilmes()
        //Metodo para que toda vez que houver o clique no botao ele renderizar e não repetir
        let tabela = document.getElementById("Tabela")
        let linhas = tabela.rows.length

        for (let index = linhas-1; index > 0; index--) {
            if (!(index == 0)) {
                tabela.deleteRow(index);
            }
        }

        //Metodo para que seja possivel apareceer os dados do Banco no front
        for (filme of filmes) {
            var table = document.getElementById('Tabela');

            var row = document.createElement("tr");

            var titulo = document.createElement("td");

            var genero = document.createElement("td");

            titulo.appendChild(document.createTextNode(filme.titulo));

            genero.appendChild(document.createTextNode(filme.idGeneroNavigation.nome));

            row.appendChild(titulo);
            row.appendChild(genero);

            table.appendChild(row);
        }



    } catch (error) {
        throw new Error(error)
    }
}