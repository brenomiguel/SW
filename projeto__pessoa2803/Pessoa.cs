namespace projeto__pessoa2803;
class Pessoa
{
   public Pessoa(){
    this.Nome = "Não informado";
    this.SobreNome = "Não informado";
    this.Idade = 0;
   }

   public Pessoa(string nome, int idade){
    this.Nome = nome;
    this.Idade = idade;
    this.SobreNome = "Não informado";
   }
   private string? Nome {get;set;}
   private string? SobreNome {get;set;}
   private int Idade {get;set;}

   public void InsereNome(string nome){
    this.Nome = nome;
   }
   public void InsereSobreNome(string sobrenome){
    this.SobreNome = sobrenome;
   }
   public void InsereIdade(int idade){
    this.Idade = idade;
   }
    public void MostraDados(){
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("SobreNome: " + this.SobreNome);
        Console.WriteLine("Idade: " + this.Idade);
    }

}
