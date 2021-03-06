window.addEventListener('load', function(event){
    document.querySelector('#cotainer-geral-click #close').addEventListener('click', function(){
        document.querySelector("#cotainer-geral-click").classList.toggle("active");
    });
    $.ajax({
        url: 'js/produtos.js',
        method: 'GET'
    }).done(function(data) {
        var produtos = JSON.parse(data);

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
            setOpenModal(coluna,produto)
            row.appendChild(coluna);
           
    
        }
    
        principal.appendChild(row);
    
    
    
    });
})

function setOpenModal(coluna, produto){
    var link = coluna.querySelector(".box-cover");
    link.addEventListener('click', function(event){
        console.log("clicou")
        openProductDescription(produto)
    })
}

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
