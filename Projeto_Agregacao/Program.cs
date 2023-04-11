namespace Projeto_Agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalho de Agregação!");
        Cartaodecredito cdc = new Cartaodecredito();
        Cliente cli = new Cliente();
        cli.Nome = "Breno Miguel";
        cdc.Numero = "8941464684646";
        cdc.DataValidade = "05/2028";
        cdc.Cliente = cli;
        
        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("O a data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente agregado é: " + cdc.Cliente.Nome);
    }
}
