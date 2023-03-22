class musico
{
    public string nombre{get; set;}
    public musico(string n,string instrumento)
    { 
        nombre=n;
        instrumento= instrumento;
    }
    public void saluda(){Console.WriteLine($"hola soy {nombre}");}


}
class bajista:musico
{
    public string bajo{get; set;}
    public bajista(string n,string b):base(n)
    {
        bajo=b;
    }
    public override void toca()
    {Console.WriteLine($"{nombre} tocando si {bajo} ");}
}


internal class Program
{

    List<musico> sodastereo = new List<musico>();
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}