namespace exercicio_de_heranca_e_polimorfismo01;
class Program
{
    static void Main(string[] args)
    {
        Cao n1 = new Cao();
        Gato n2 = new Gato();
        Humano n3 = new Humano();


        Console.WriteLine("Cão  " + n1.Fala());
        Console.WriteLine("Gato  " + n2.Fala());
        Console.WriteLine("Homem  " + n3.Fala());
    }
}
