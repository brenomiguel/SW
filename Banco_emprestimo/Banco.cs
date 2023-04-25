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
    public double MostrarSaldo(){
        return this.Saldo + this.Limite;
    }
    public double parcela{get; set;}
    public double valor{get; set;}
    public string emprestimo(int parcelas, double dinheiro){
        this.parcela = parcelas;
        this.valor = dinheiro;

        double div = dinheiro/parcelas;
        double mult = dinheiro*0.06;
        double aaa = div+mult;
        double bbb = parcelas*aaa;
        string resultado = "O valor da sua parcela sem juros é: "+ div +". O valor da parcela com juros: "+ mult + ". O valor do juros com prestações é de: "+ aaa +"e o valor total a pagar é de: "+bbb;
        return resultado;


    }
    public void imprimi(string texto){
        Console.WriteLine(texto);
    }
    

    
}

