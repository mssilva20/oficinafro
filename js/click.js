window.openProductDescription = function (produto){
    var modalContent = document.getElementById("container-clickimg");
    modalContent.querySelector(".title").innerText = produto.nome; 
    modalContent.querySelector(".description").innerText = produto.descricao; 
    modalContent.querySelector(".image img").src = produto.urlImagem;
    modalContent.querySelector(".price span").innerText = produto.valor; 

    var scrollInterval = window.pageYOffset;

    modalContent.style.top = "calc(" + scrollInterval + "px + 80px)";

    document.querySelector("#cotainer-geral-click").classList.toggle("active");
    
}
