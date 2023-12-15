// Função para mostrar o modal e a sobreposição
function mostrarModal() {
    document.getElementById("modalOverlay").style.display = "block";
    var modal = document.getElementById("modal");
    modal.style.right = '0';
}

// Função para ocultar o modal e a sobreposição
function fecharModal() {
    document.getElementById("modalOverlay").style.display = "none";
    var modal = document.getElementById("modal");
    modal.style.right = '-100%';
}