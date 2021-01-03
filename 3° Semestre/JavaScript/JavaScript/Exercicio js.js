/*
Declare uma variável `pessoa`, que receba suas informações pessoais.
As propriedades e tipos de valores para cada propriedade desse objeto devem ser:
- `nome` - String
- `sobrenome` - String
- `genero` - String
- `idade` - Number
- `altura` - Number
- `peso` - Number
- `andando` - Boolean - recebe "falso" por padrão
- `caminhouQuantosMetros` - Number - recebe "zero" por padrão
*/

//

var pessoa = {
    Nome: 'Gustavo',
    Sobrenome: 'Casco',
    Genero: "Masculino",
    Idade: 1,
    Altura: 1.75,
    Peso: 68,
    Andando: false,
    Caminhoqntsmetros: 1,
};
console.log(pessoa)


/*
Crie um método chamado `nomeCompleto`, que retorne a frase:
- "Olá! Meu nome é [NOME] [SOBRENOME]!"
*/

var Nome = 'Gustavo';
var Sobrenome = 'Casco';

function nomeCompleto() {

    return 'Meu nome completo é ' + Nome + ' ' + Sobrenome + ' ';
};

console.log(nomeCompleto())

/*
Crie um método chamado `mostrarIdade`, que retorne a frase:
- "Olá, eu tenho [IDADE] anos!"
*/

var idade2 = 18

function MostrarIdade() {
    return 'Minha idade é ' + idade2 + ' anos';
}

console.log(MostrarIdade())

/*
Crie um método chamado `mostrarPeso`, que retorne a frase:
- "Eu peso [PESO]Kg."
*/

var peso = 68

function MostrarPeso() {
    return 'Eu peso ' + peso + ' KG'
}
console.log(MostrarPeso())
    /*
    Crie um método chamado `mostrarAltura` que retorne a frase:
    - "Minha altura é [ALTURA]m."
    */

var altura = 1.78

function MostrarAltura() {
    return 'Minha altura é ' + altura + ' m';
}
console.log(MostrarAltura())

/*
Agora, vamos deixar a brincadeira um pouco mais divertida! :D
Crie um método para o objeto `pessoa` chamado `apresentacao`. Esse método deve
retornar a string:
- "Olá, eu sou o [NOME COMPLETO], tenho [IDADE] anos, [ALTURA], meu peso é [PESO] e, só hoje, eu já caminhei [CAMINHOU QUANTOS METROS] metros!"

Só que, antes de retornar a string, você vai fazer algumas validações:
- Se o `genero` de `pessoa` for "Feminino", a frase acima, no início da
apresentação, onde diz "eu sou o", deve mostrar "a" no lugar do "o";
- Se a idade for `1`, a frase acima, na parte que fala da idade, vai mostrar a
palavra "ano" ao invés de "anos", pois é singular;
- Se a quantidade de metros caminhados for igual a `1`, então a palavra que
deve conter no retorno da frase acima é "metro" no lugar de "metros".
- Para cada validação, você irá declarar uma variável localmente (dentro do
método), que será concatenada com a frase de retorno, mostrando a resposta
correta, de acordo com os dados inseridos no objeto.
*/
function apresentacao() {
    var Genero2 = 'a';
    var Ano = 'anos';
    var metros = 'metros';

    if (pessoa.Genero === 'Feminino') {
        Genero2 = o
    }

    if (pessoa.Idade === 1) {
        Ano = 'ano';
    }

    if (pessoa.Caminhoqntsmetros === 1) {
        metros = 'metro';
    }

    return 'Olá, eu sou ' + Genero2 + ' ' + pessoa.Nome + ' ' + pessoa.Sobrenome + ', tenho ' + pessoa.Idade + ' ' + Ano + ', ' + pessoa.Altura + ', meu peso é ' + pessoa.Peso + ' e, só hoje, eu já caminhei ' + pessoa.Caminhoqntsmetros + ' ' + metros + '!'
};

console.log(apresentacao());