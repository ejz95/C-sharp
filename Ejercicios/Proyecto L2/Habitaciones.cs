using System;
public class Habitaciones
//Propiedades
{
    public int Numero {get; set;}
    public int Precio {get; set;}
    public int Camas {get;set;}
    public string Tipo {get;set;}
    public bool Disponibilidad {get; set;}

//constructor
    public Habitaciones(int numero,int precio, int camas,string tipo)
    {
        Numero = numero;
        Precio = precio;
        Camas = camas;
        Tipo = tipo;    
    }
}    