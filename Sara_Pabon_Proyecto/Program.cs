// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vehiculos vehiculo_1 = new Vehiculos();
Carros vehiculo_2 = new Carros();
Carros vehiculo_3 = new Motos();

vehiculo_1.Id = 1;
vehiculo_1.Marca = "Renault";
vehiculo_1.Kilometraje = 100m;
vehiculo_1.Fecha = DateTime.now;
vehiculo_1.Usado = true;
vehiculo_1.Propietarios.Add(new Propietarios { Id = 1, Nombre = "Laura" });
vehiculo_1.Propietarios.Add(new Propietarios { Id = 2, Nombre = "Miguel" });

vehiculo_2.Id = 1;
vehiculo_2.Marca = "Suzuki";
vehiculo_2.Kilometraje = 0m;
vehiculo_2.Fecha = DateTime.now;
vehiculo_2.Usado = false;
vehiculo_2.CantNeumaticos = 4;

vehiculo_3.Id = 1;
vehiculo_3.Marca = "Yamaha";
vehiculo_3.Kilometraje = 25m;
vehiculo_3.Fecha = DateTime.now;
vehiculo_3.Usado = true;
vehiculo_3.TipoManubrio = "Manual";

Console.WriteLine(vehiculo_1.Id + " " + vehiculo_1.Marca + " " + vehiculo_1.Kilometraje + " " + vehiculo_1.Usado);
Console.WriteLine(vehiculo_2.Id + " " + vehiculo_2.Marca + " " + vehiculo_2.Kilometraje + " " + vehiculo_2.Usado);
Console.WriteLine(vehiculo_3.Id + " " + vehiculo_3.Marca + " " + vehiculo_3.Kilometraje + " " + vehiculo_3.Usado);

foreach (var elemento in vehiculo_1.Propietarios){
    Console.WriteLine(elemento.Nombre);
}


public class Vehiculos{
    public int Id;
    public string? Marca = "";
    public decimal Kilometraje;
    public bool Usado;
    public DateTime Fecha;
    public List<Propietarios>? Propietarios;
}//Fin Vehiculos

public class Carros : Vehiculos {
    public int Id;
    public int CantNeumaticos;
}//Fin Carros

public class Motos : Vehiculos {
    public int Id;
    public string? TipoManubrio;
}//Fin Motos

public class Propietarios {
    public int Id;
    public string? Nombre;
}//Fin Propietarios
