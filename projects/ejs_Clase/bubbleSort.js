const assert = require('assert'); //da acceso a una libreria

function bubbleSort(array) {
    for (let j = 0; j < array.length; j++) {
        for (let i = 0; i < array.length - 1; i++) {
            console.log(`item ${array[i]} > ${array[i+1]}??`);
            if (array[i] > array[i+1]) {
                let aux = array[i+1];
                array[i+1] = array[i];
                array[i] = aux;
            }
        }
    }
    return array;
}

let result = bubbleSort([0, 4, 8, -2, 12, 6, -4, -1]);
assert.deepStrictEqual([-4, -2, -1, 0, 4, 6, 8, 12], result);

result = bubbleSort([8, 9, 6, 1, 5, 4, 7, 2]);
assert.deepStrictEqual([1, 2, 4, 5, 6, 7, 8, 9], result);

console.log("END");