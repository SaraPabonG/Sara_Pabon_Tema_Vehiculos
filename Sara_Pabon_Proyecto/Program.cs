// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vehiculos vehiculo_1 = new Vehiculos();
Vehiculos vehiculo_2 = new Carros();
Vehiculos vehiculo_3 = new Motos();

public class Vehiculos{
    public int Id;
    public string? Nombre = "";
    public decimal Kilometraje;
    public bool Usado;
    public DateTime Fecha;
}//Fin Vehiculos

public class Carros : Vehiculos {
    public int CantNeumaticos;
    public List<Propietarios>? Propietarios;
}//Fin Carros

public class Motos : Vehiculos {
    public string? TipoManubrio;
    public List<Propietarios>? Propietarios;
}//Fin Motos

public class Propietarios {
    public int Id;
    public string? Nombre;
}//Fin Propietarios
