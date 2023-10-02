// Declarar un array numérico (entero) y crear un método que imprima:
// La suma de todos los elementos
// El elemento más grande
// El elemento más pequeño
// La media de los elementos



function doCalculation(array) {
    array = [1,2,3,4];
    let suma = 0;
    let max = 0;
    let min = 10;
  
    for (let i = 0; i < array.length; i++) {
        suma += array[i];
        if (array[i] > max) {
            max = array[i];
        }
        if (array[i] < min) {
            min = array[i];
        }
    }
  
    let media = suma / array.length;
  
    console.log(`La suma de todos los elementos es: ${suma}`);
    console.log(`El elemento más grande es: ${max}`);
    console.log(`Elemento mas pequeño es: ${min}`);
    console.log(`La media de los elementos es: ${media}`);
    console.log("");
}



doCalculation([1,2,3,4])
doCalculation([5,5,5,5])
doCalculation([1,1,1,2,2,2,3,3,3,4,4,4,5,5,5])