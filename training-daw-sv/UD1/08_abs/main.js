//Definir una función que reciba un número entero y muestre por pantalla su valor absoluto.

const assert = require('assert').strict;

function abs(value) {
    return Math.abs(value);
}

assert.strictEqual(abs(4), 4)
assert.strictEqual(abs(-4), 4)
assert.strictEqual(abs(0), 0)

console.log(abs(4));
console.log(abs(-4));
console.log(abs(0));