window.addEventListener('load', function(event){ 

    document.querySelector('#btn-carrinho').addEventListener('click', function(){
        document.querySelector("#container-carrinho-geral").classList.toggle("active");
    });
    document.querySelector('#container-carrinho-geral #close').addEventListener('click', function(){
        document.querySelector("#container-carrinho-geral").classList.toggle("active");
    });


});





