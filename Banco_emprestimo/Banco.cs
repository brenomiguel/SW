namespace projeto_conta;
class Banco
{
    public int Numero {get; set;}
    private double Saldo { get;  set;}
    public double Limite {get; private set;}
    public double num1 {get; set;}
    public double num2 {get; set;}
    public double num3 {get; set;}


    

    public void AjustarLimite(double valor){
        this.Limite = valor;
    }
    public void Depositar( double valor){
        this.Saldo += valor;
    }
    public void Sacar(double valor){
        if (this.Saldo + this.Limite <= valor){
            Console.WriteLine("Você esta sacando mais do que você tem");
        }else{
             this.Saldo -= valor;
        }
    }
    public string soma(double n1, double n2, double n3){
        this.num1 = n1;
        this.num2 = n2;
        this.num3 = n3;
        double soma1 = this.num1 * this.num2;
        double soma2 = this.num1 / this.num3;
        

        double resultado = this

    
        
    }
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }
    public void imprime(string texto){
        Console.WriteLine(texto);
    }

}