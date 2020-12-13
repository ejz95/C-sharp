using System;
public class Huesped: Herencia
{
    public int Reserva {get; set;}
    public string Nombre {get; set;}
    public int Habitacion {get; set;}
    
    public Huesped(int reserva, string  nombre, int habitacion)
    {
        Reserva = reserva;
        Nombre = nombre;
        Habitacion = habitacion;
    }
}

    
        
        
    