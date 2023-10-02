//Crear metodo que pinte (mediante console.log) las tablas de multiplicar del 1 al 10

function printMultiplicationTables() {
    for (let i = 1; i <= 10; i++) {
        let result = `Tabla del ${i}:  `;
        for (let j = 1; j <= 10; j++) {
            let resultMulti = i * j;
            result += `${String(resultMulti).padStart(4, ' ')} `;
        }
        console.log(result);
    }
}

printMultiplicationTables()
// expected output
//     1   2   3   ...
// 1   1   2   3   ...
// 2   2   4   6   ...
// 3   3   6   9   ...
// 4   4   8   12  ...
// 5   5   10  15  ...
// 6   6   12  18  ...
// 7   7   14  21  ...
// 8   8   16  24  ...
// 9   9   18  27  ...
// 10  10  20  30  ...
