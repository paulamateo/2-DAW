//Definir una función que reciba un número entero e imprima sus números pares contiguos.

const assert = require('assert').strict;

function nextPairs(value) {
    if (value % 2 !== 0 ) {
        value--;
    }
    
}

assert.deepStrictEqual(nextPairs(3), [2,4])
assert.deepStrictEqual(nextPairs(4), [2,6])