class Coche {
    constructor(marca, modelo, consumoPor100) {
        this.marca = marca;
        this.modelo = modelo;
        this.consumoPor100 = consumoPor100;
        this.depositoGasolina = 0;
    }
  
    repostar(litros) {
        if (litros > 0) {
            this.depositoGasolina += litros;
            console.log(`${litros} litros añadidos.`);
        }else {
            console.log(`Con ${litros} no puedes rellenar el depósito. Hazme el favor de hacerlo bien.`);
        }
        console.log(`TOTAL DEPÓSITO: ${depositoGasolina}`);
    }

    move(distancia) {
        let litrosNecesarios = distancia/this.consumoPor100;
        if (litrosNecesarios < this.depositoGasolina) {
            this.depositoGasolina =- litrosNecesarios;
            console.log(`Se han recorrido ${distancia} km. Se han gastado ${litrosNecesarios} litros, y por lo tanto, quedan ${this.depositoGasolina} litros en el depósito.`);
        }else {
            console.log(`No tienes suficiente gasolina.`)
        }
    }

    restante() {
        
    }



    
    //PRUEBA




}