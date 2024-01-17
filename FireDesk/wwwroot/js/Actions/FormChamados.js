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
//Função para o select
let select = document.querySelector('.select2'),
    selectedValue = document.getElementById('selected-value'),
    optionsViewButton = document.getElementById('options-view-button'),
    inputsOptions = document.querySelectorAll('.option input')

inputsOptions.forEach(input => {
    input.addEventListener('click', event => {
        selectedValue.textContent = input.dataset.label

        const isMouseOrTouch =
            event.pointerType == "mouse" ||
            event.pointerType == "touch"
        isMouseOrTouch && optionsViewButton.click()
    })
})