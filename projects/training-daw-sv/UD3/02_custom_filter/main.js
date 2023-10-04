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


function pairs(number) {
    return number % 2 === 0;
}

function gt15(number) {
    return number > 15;
}

function lt10(number) {
    return number < 10;
}


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