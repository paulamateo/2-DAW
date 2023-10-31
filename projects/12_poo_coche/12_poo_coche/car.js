class Car {
    constructor(marca, modelo, consumoPor100) {
        this.marca = marca
        this.modelo = modelo
        this.consumoPor100 = consumoPor100
        this.deposito = 0
    }
    reposta(litros) {
        this.deposito += litros
    }
    move(distancia) {
        this.deposito -= distancia * this.consumoPor100 / 100
    }
    restante() {
        return this.deposito / this.consumoPor100 * 100
    }
}

class Truck {}

module.exports = {
    Car,
    Truck
}