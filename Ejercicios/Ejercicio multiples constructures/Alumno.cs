public class Alumno
{
    public int Id { get; set; }
    public string Primernombre { get; set; }
    public string Segundonombre { get; set; }
    
    
    public Alumno(){
    
        Id =1;   
    }

    public Alumno(int id){
        Id=id;
    }
    
    public Alumno(string primernombre, string segundonombre)
    {
       Primernombre =  primernombre;
       Segundonombre = segundonombre;
    }
}
