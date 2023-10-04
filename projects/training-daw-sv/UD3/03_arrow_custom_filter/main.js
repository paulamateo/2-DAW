/*function isPair(value) {
    return value % 2 == 0;
}

isPair = (value) => value % 2 == 0;*/


const assert = require('assert').strict;

function select(array, condition) {
    let result = [];
    for (let i = 0; i < array.length; i++) {
        if (condition(array[i])) {
            result.push(array[i]);
        }
    }
    return result;
}


pairs = (number) => number % 2 === 0;
gt15 = (number) => number > 15;
lt10 = (number) => number < 10;


let values = [1, 2, 3, 5, 7, 13, 17, 23, 29]

// sólo pares
assert.deepStrictEqual(select(values, pairs), [2])
console.log(select(values, pairs));

// mayores que 15
assert.deepStrictEqual(select(values, gt15), [17, 23, 29])
console.log(select(values, gt15));

// menores de 10
assert.deepStrictEqual(select(values, lt10), [1, 2, 3, 5, 7])
console.log(select(values, lt10));