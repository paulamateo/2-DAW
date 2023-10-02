//Definir una función que reciba un número entero (el número total de segundos) y muestre los segundos en horas minutos y segundos.


const assert = require('assert').strict;

function toHoursMinutesSeconds(value) {
    const horas = Math.floor(value / 3600);
    const minutos = Math.floor((value % 3600) / 60);
    const segundos = value % 60;

    return `${horas}:${minutos}:${segundos}`;
}

assert.deepStrictEqual(toHoursMinutesSeconds(3600), "1:0:0")
assert.deepStrictEqual(toHoursMinutesSeconds(3720), "1:20:0")
assert.deepStrictEqual(toHoursMinutesSeconds(3725), "1:20:5")