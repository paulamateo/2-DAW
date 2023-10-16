const input = [1, -4, 12, 0, -3, 29, -150];

//FILTRA CUALES SON POSITIVOS Y CUALES NO
let resultPositive = input.filter((num) => num > 0);
console.log(resultPositive);

//SUMA POSITIVOS
function PositiveElement(num) {
    if (num < 0) {
        return 0;
    }else {
        resultSumArray = input.reduce((accumulator, value) => accumulator + value);
        return resultSumArray;
    }
}


console.log(PositiveElement(input));
//NO FUNCIONA

https://www.crocoder.dev/blog/map-filter-reduce-exercises/#sum-of-every-positive-element
