$.ajax({
    url: 'js/produtos.js',
    method: 'GET'
}).done(function(data){
    console.log(data);
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
})


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
