using System;
namespace propiedades
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1,"Juan", "Perez");
            Alumno b = new Alumno(1,"maria","martinez");
           
            a.inactivarAlumno();
            Console.WriteLine(a.NombreCompleto());
            Console.WriteLine(b.NombreCompleto());
        
            Console.WriteLine(" ");
            
            a.activarAlumno();
            Console.WriteLine(a.NombreCompleto());
            Console.WriteLine(b.NombreCompleto());
            
            
        }
    }
}