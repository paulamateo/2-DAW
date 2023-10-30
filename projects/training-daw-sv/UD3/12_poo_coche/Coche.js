class Coche {
    constructor(marca, modelo, consumoPor100) {
        this.marca = marca;
        this.modelo = modelo;
        this.consumoPor100 = consumoPor100;
        this.depositoGasolina = 0;
    }
  
    reposta(litros) {
        if (litros > 0) {
            this.depositoGasolina += litros;
            console.log(`${litros} litros añadidos.`);
        } else {
            console.log(`Con ${litros} no puedes rellenar el depósito. Hazme el favor de hacerlo bien.`);
        }
        console.log(`TOTAL DEPÓSITO: ${this.depositoGasolina}`);
    }

    move(distancia) {
        let litrosNecesarios = distancia*this.consumoPor100;
        if (litrosNecesarios <= this.depositoGasolina) {
            this.depositoGasolina -= litrosNecesarios;
            console.log(`Se han recorrido ${distancia} km. Se han gastado ${litrosNecesarios} litros, y por lo tanto, quedan ${this.depositoGasolina} litros en el depósito.`);
        } else {
            console.log(`No tienes suficiente gasolina.`)
        }
    }

    restante() {
        return `Se pueden hacer ${this.depositoGasolina/this.consumoPor100} km más.`;
    }
}

const coche1 = new Coche('Ferrari', 'f50', 25);
const coche1 = new Coche('Volvo', 'XC60', 6.1);
coche1.reposta(400);
coche1.move(50);
console.log(coche1.restante());


reposta() {
    this.deposito += litros;
}

move {
    this.deposito =- distancia*this.consumoPor100/100;
}

restante() {
    return this.deposito/this.consumoPor100*100;
}

6507.377


module.exports = Car

