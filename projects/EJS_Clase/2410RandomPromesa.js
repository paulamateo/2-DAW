/*Realizar una función que genere un número random entre 0 y 10, cuando el número sea menor o igual 5 la 
promesa debe ser resuelta, caso contrario debe ser rechazada. Independientemente del resultado de la 
promesa mostrar el mensaje "Promesa acabada" para indicar que el proceso terminó*/


const myPromise = new Promise((resolve, reject) => {
    const number = Math.floor(Math.random()*10);
    setTimeout(() => {
        console.log("Número random: " +number)
        if (number <= 5) {
            resolve("Promesa cumplida");
        }else {
            reject("Promesa rechazada");
        }
    })
});



myPromise
    .then(number => {
        console.log(number);
    })

    .catch(error => {
        console.error(error);
    })

    .finally(() => {
        console.log("Promesa acabada");
    });




//MANERA DE OLIVER
// function generateRandom() {
//     return new Promise((resolve, reject) => {
//         //asincrono
//         reject('Hola mundo')
//     })
// }

// generateRandom()
//     .then(value => console.log(value))
//     .catch(err => console.log(`error ${err}`))