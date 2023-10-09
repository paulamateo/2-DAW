const assert = require('assert');

function survivorNumber(n) {
    let numbers = [];
    for (let i = 1; i < 1000; i++) {
        if (i % 2 !== 0) {
            numbers.push(i);
            if () {
                return true;
            }else {
                return false;
            }

        }
    }
    return numbers;
}


survivorNumber();


//COMPROBACION
// let n = 89;
// let result = survivorNumber(n);
// console.log(`¿Es ${n} un número superviviente? Respuesta: ${result}`)
