function tocaSom (idElementoAudio) {

    document.querySelector(idElementoAudio).play();
}

const listaDeTeclas = document.querySelectorAll('.tecla');

let contador = 0;

//enquanto
while (contador < listaDeTeclas.length) {

    const tecla = listaDeTeclas[contador];
    const instrumento = tecla.classList[1];
    //Abaixo uma Template String em JS
    const idAudio = `#som_${instrumento}`;

    console.log(idAudio);

    tecla.onclick = function () {
        tocaSom(idAudio);
    }

    contador = contador + 1;

    console.log(contador);
}

// Abaixo Codigo Antigo -------------------------
// // Tim --------
// function tocaSomPom () {
//     document.querySelector('#som_tecla_pom').play();
// }
// document.querySelector('.tecla_pom').onclick = tocaSomPom;


// // Tim --------
// function tocaSomClap () {
//     document.querySelector('#som_tecla_clap').play();
// }
// document.querySelector('.tecla_clap').onclick = tocaSomClap;


// // Tim --------
// function tocaSomTim () {
//     document.querySelector('#som_tecla_tim').play();
// }
// document.querySelector('.tecla_tim').onclick = tocaSomTim;


// // Puff --------
// function tocaSomPuff () {
//     document.querySelector('#som_tecla_puff').play();
// }
// document.querySelector('.tecla_puff').onclick = tocaSomPuff;


// // Tim --------
// function tocaSomSplash () {
//     document.querySelector('#som_tecla_splash').play();
// }
// document.querySelector('.tecla_splash').onclick = tocaSomSplash;


// // Tim --------
// function tocaSomToim () {
//     document.querySelector('#som_tecla_toim').play();
// }
// document.querySelector('.tecla_toim').onclick = tocaSomToim;


// // Tim --------
// function tocaSomPsh () {
//     document.querySelector('#som_tecla_psh').play();
// }
// document.querySelector('.tecla_psh').onclick = tocaSomPsh;


// // Tim --------
// function tocaSomTic () {
//     document.querySelector('#som_tecla_tic').play();
// }
// document.querySelector('.tecla_tic').onclick = tocaSomTic;


// // Tim --------
// function tocaSomTom () {
//     document.querySelector('#som_tecla_tom').play();
// }
// document.querySelector('.tecla_tom').onclick = tocaSomTom;