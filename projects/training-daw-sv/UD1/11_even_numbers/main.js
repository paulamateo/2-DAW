//Crear un método que recorra los 100 primeros números mostrando sólo los valores pares


function evenNumbers() {
    let result = '';

    for (let i = 2; i <= 100; i += 2) {
        result += i + ' ';
    }

    console.log(result);
}

evenNumbers();
// expected output 2,4,6,8,10......98