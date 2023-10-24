public class Coche {
    private String Modelo;
    private String Marca;
    private double ConsumoPor100;
    private double Gasolina;
}


public Coche(String modelo, String marca, double consumoPor100, double gasolina) {
    this.Modelo = modelo;
    this.Marca = marca;
    this.ConsumoPor100 = consumoPor100;
    this.Gasolina = gasolina;
}

public String reposta(double litros) {
    if (litros > 0) {
        this.Gasolina += litros;
    }
    return "Se han repostado" +litros;
}

public static void move(int distancia) {
    
}

public static void restante() {

}