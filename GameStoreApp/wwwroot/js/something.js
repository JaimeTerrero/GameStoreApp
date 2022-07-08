const agregar = document.querySelector("#agregar");

document.addEventListener("DOMContentLoaded", () => {
    agregar.addEventListener("click", muestraAlgo);
});

function muestraAlgo(e) {
    e.preventDefault();

    agregar.textContent = "Agregado!";

    swal("Bien hecho!", "El producto se ha agregado correctamente", "success");

    setTimeout(() => {
        window.location.reload();
    }, 3000);
}