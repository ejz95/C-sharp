using System;
namespace propiedades
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
           
            a.Primernombre = "Casimiro";
            a.Segundonombre = "Paz";        
            
            Alumno b = new Alumno();
            b.Id = 2;
            b.Primernombre = "maria";
            b.Segundonombre = "martinez";
            
            Alumno c = new Alumno(3);
            c.Primernombre = "Pedro";
            c.Segundonombre = "";
            
            Alumno d = new Alumno("Juan", "Jimenez");
           
            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);   
            Console.WriteLine(d.Primernombre + " " + d.Segundonombre);
        }
    }
}