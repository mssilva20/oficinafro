var produtos = [
    {
        nome: "Camisa Masc Tshirt",
        descricao: "Camisa Masc Tshirt",
        valor: 29.90,
        urlImagem: "images/camisatshirt.jpg",
        id: 1,
        tipo: "Camisa"
    },
    
    {
        nome: "Moletom Pantera negra",
        descricao: "Moletom Pantera negra",
        valor: 100.00,
        urlImagem: "images/moletompn.png",
        id: 2,
        tipo: "Blusas"
    },

    {
        nome: "Bata florida solta",
        descricao: "Descrição da peça",
        valor: 58.90,
        urlImagem: "images/bata-florida-solta.jpg",
        id: 3,
        tipo: "Bata"
    },

    {
        nome: "Meia \"Resistência Afro\"",
        descricao: "Resistência Afro",
        valor: 19.90,
        urlImagem: "images/meiaafro.jpg",
        id: 4,
        tipo: "Meia"
    },

    {
        nome: "calca-jeans-skinny",
        descricao: "Colete Afro ",
        valor: 42.90,
        urlImagem: "images/calca-jeans-skinny.jpg",
        id: 5,
        tipo: "Calça Jens Masculina"
    },
    {
        nome: "Conjunto Masc floral",
        descricao: "Conjunto Masc Floral",
        valor: 60.00,
        urlImagem: "images/conjuntofloral.jpg",
        id: 6,
        tipo: "Conjuntos"
    },

    {   
    nome: "Colete Masculino",
    descricao: "Conjunto Masc Floral",
    valor: 42.00,
    urlImagem: "images/colete.jpg",
    id: 7,
    tipo: "Colete"
    },

{   
    nome: "Kimono Afro",
    descricao: "Conjunto Masc Floral",
    valor: 67.99,
    urlImagem: "images/kimonoafro.jpg",
    id: 8,
    tipo: "Kimono"
    },

    {   
        nome: "Macacão Feminino",
        descricao: "Macacão Feminino",
        valor: 74.90,
        urlImagem: "images/macacao.jpg",
        id: 8,
        tipo: "Macacão"
        },
    
]

window.addEventListener('load', function(event){
    
    var principal = document.querySelector("#principal");
    var row = document.createElement("div");
    row.className = "row";    

    for(var i = 0; i < produtos.length; i++){
        var produto = produtos[i];
        var coluna = document.querySelector(".destinos-col.display-none").cloneNode(true);
        coluna.className= "destinos-col";

        setImagem(coluna, produto);
        setNome(coluna, produto);
        setValor(coluna, produto);
        setTipo(coluna, produto);
        row.appendChild(coluna);
       

    }

    principal.appendChild(row);



});


function setImagem(coluna, produto){
    var imagem = coluna.querySelector(".box-cover img");
    imagem.setAttribute("src", produto.urlImagem);
}

function setNome(coluna, produto){
    var elementoTitulo = coluna.querySelector(".box-detalhe-info h2");
    elementoTitulo.innerText = produto.nome;
}

function setValor(coluna, produto){
    var elementoValor = coluna.querySelector(".box-detalhe-info p");
    elementoValor.innerText = "R$ " + produto.valor;
}

function setTipo(coluna, produto){
    var elementoTipo = coluna.querySelector(".box-nome");
    elementoTipo.innerText = produto.tipo;
}
