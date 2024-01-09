function calculateMCD(a, b) {
    let c;
    
    while (b) {
        b = a % b;
        a = c;
    }

    return a;
}


//prueba
const a = 12;
const b = 24;
const mcd = calculateMCD(a, b);