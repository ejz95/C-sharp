using System;
using System.Collections.Generic;

public class MatrizdeDatos
{

    public List<Habitaciones> Listadecuartos{get; set;}
    public List<Huesped> ListadeHuesped{get; set;}
    //constructor
    public MatrizdeDatos()
    {
      Listadecuartos = new List<Habitaciones>();
      mostrarhabitaciones();
      ListadeHuesped = new List<Huesped>();
      mostrarhuesped();   
    }
    
     //habitaciones
    private void mostrarhabitaciones()
    {
      Habitaciones sim = new Habitaciones(1,300,2,"Parejas");
      Listadecuartos.Add(sim);
      Habitaciones sim2 = new Habitaciones(2,300,2,"Parejas");
      Listadecuartos.Add(sim2);
      Habitaciones sim3 = new Habitaciones(3,300,2,"Parejas");
      Listadecuartos.Add(sim3);
      Habitaciones delux = new Habitaciones(4,600,2,"Familiar");
      Listadecuartos.Add(delux);
      Habitaciones delux2 = new Habitaciones(5,600,2,"Familiar");
      Listadecuartos.Add(delux2);
      Habitaciones delux3 = new Habitaciones(6,600,2,"Familiar");
      Listadecuartos.Add(delux3);    
    }

    public void buscarhabitacion()
    { Console.Clear();
      Console.WriteLine("Todas Las Habitaciones");
      Console.WriteLine(" ");
      foreach(var Habitaciones in Listadecuartos)
      {
        Console.WriteLine("Numero de La habitacion: "+Habitaciones.Numero+"|"+"Precio: "+Habitaciones.Precio+"|"+"Camas: "+Habitaciones.Camas+"|"+"Tipo: "+Habitaciones.Tipo);
      }
    }

    //clientes
    private void mostrarhuesped()
    {
      Huesped huesped1 = new Huesped(001,"Juan Tomate",1);
      ListadeHuesped.Add(huesped1);
      Huesped huesped2 = new Huesped(002,"Mario Bros",2);
      ListadeHuesped.Add(huesped2);
      Huesped huesped3 = new Huesped(003,"Elvis Vaultteck",3);
      ListadeHuesped.Add(huesped3);
      Huesped huesped4 = new Huesped(004,"Dark Seid",4);
      ListadeHuesped.Add(huesped4);
    }
    //muestra huesped
    public void buscarhuesped()
    { Console.Clear();
      Console.WriteLine("Todos Los Huesped");
      Console.WriteLine(" ");
      foreach(var Huesped in ListadeHuesped)
      {
        Console.WriteLine("Numero de Reserva: "+Huesped.Reserva+"|"+"Nombre del Huesped: "+Huesped.Nombre);
      }
    }

    private void reservar(int numero,string reservas,string clientes)
    {
      foreach (var habitaciones in Listadecuartos)
        {
            if (habitaciones.Numero == numero)
            {
                if (reservas == "Reservas"||reservas == "reservas"||reservas == "RESERVAS") 
                {
                    habitaciones.Numero=habitaciones.Numero+Convert.ToInt32(clientes);  
                } 
        
            }         
        }
    }

      public void ingresoCliente() 
      {
        string numero ="" ;
        string reservas = "";
        string nombre = "";
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("++++++++");
        Console.WriteLine("Reservas");
        Console.WriteLine("++++++++");
        Console.Write("Ingrese el numero de la habitacion: ");
        numero = Console.ReadLine();
        Console.Write("Ingrese el nombre del huesped: ");
        nombre = Console.ReadLine();
        reservar(Int32.Parse(numero),nombre, "reservas");
    }
}    