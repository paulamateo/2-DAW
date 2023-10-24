/*Realizar una función que genere un número random entre 0 y 10, cuando el número sea menor o igual 5 la 
promesa debe ser resuelta, caso contrario debe ser rechazada. Independientemente del resultado de la 
promesa mostrar el mensaje "Promesa acabada" para indicar que el proceso terminó*/

function generateRandom() {
    return new Promise((resolve, reject) => {
        const number = Math.floor(Math.random()*10);
        console.log(`Número random: ${number}`);
        if (number <= 5) {
            resolve('Promesa cumplida');
        }else {
            reject('Promesa rechazada');
        }
    })
}

generateRandom()
    .then(value => console.log(value))
    .catch(err => console.log(`Error: ${err}`))
    .finally(() => console.log('PROMESA ACABADA'));