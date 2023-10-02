function hello() {
    return "Hola, mundo!"
}

console.log(hello());


//DECIR SI UN AÑO ES BISIESTO O NO
function esBisiesto(year) {
    if (year % 4 === 0 && year % 100 === 0 & year % 400 === 0 || year % 4 === 0 && year % 100 === 0) {
        return true;
    }else {
        return false;
    }
}

//SOLUCION CLASE
function leap(year) {
    if (year % 4 === 0) {
        if (year % 100 === 0) {
            if (year % 400 === 0) {
                return true;
            }else {
                return false
            }
        }
        return true;
    }else {
        return false;
    }
}

if (leap(2000) == false) {
    console.log("Error con 2000");
}

if (leap(2100) == true) {
    console.log("Error con 2100");
}

if (leap(2000) == false) {
    console.log("Error con 200");
}

console.log("Ejecución finalizada");