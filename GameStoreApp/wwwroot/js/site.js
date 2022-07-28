/*const form = document.querySelector("#form");*/
const algo = document.querySelector("#algo");
const result = document.querySelector("#result");

document.addEventListener('DOMContentLoaded', () => {
    algo.addEventListener('click', showAlgo);
});

function showAlgo(e) {
    e.preventDefault();

    const cantidad = document.querySelector("#cantidad").value;

    if (cantidad === "0") {
        swal("Error!", "Debe de seleccionar una cantidad antes de agregar al carrito", "error");

        return;
    }

    algo.textContent = "Agregado!";
    swal("Bien hecho!", "El producto fue agregado al carrito", "success");

    setTimeout(() => {
        window.location.reload();
    }, 3000);
}

function Spinner() {
    const divSpinner = document.createElement('div');
    divSpinner.classList.add('sk-circle');
    divSpinner.innerHTML = `
      <div class="sk-circle1 sk-child"></div>
      <div class="sk-circle2 sk-child"></div>
      <div class="sk-circle3 sk-child"></div>
      <div class="sk-circle4 sk-child"></div>
      <div class="sk-circle5 sk-child"></div>
      <div class="sk-circle6 sk-child"></div>
      <div class="sk-circle7 sk-child"></div>
      <div class="sk-circle8 sk-child"></div>
      <div class="sk-circle9 sk-child"></div>
      <div class="sk-circle10 sk-child"></div>
      <div class="sk-circle11 sk-child"></div>
      <div class="sk-circle12 sk-child"></div>
    `;

    result.appendChild(divSpinner);

    setTimeout(() => {
        result.remove();
    }, 750);
}