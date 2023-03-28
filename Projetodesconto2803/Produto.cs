namespace Projetodesconto2803;
class Produto
{
    public Produto(){
        this.Nome = "tic toc";
    }
    public Produto(string nome){
        this.Nome = nome;
        this.Preco = 10;

    }
    public Produto(string nome, int desconto){
        this.Nome = nome;
        this.Preco = 10 - (10*desconto/100);
    }
    private string? Nome {get;set;}
    private double Preco {get;set;}

    public void AlterarNome(string nome){
        this.Nome = nome;
    }
    public void AlterarPreco(double preco){
        this.Preco = preco;
    
    }
    public void MostrarDados(){
        Console.WriteLine("Nome: "+ this.Nome);
        Console.WriteLine("Preço: " + this.Preco);
    }
}