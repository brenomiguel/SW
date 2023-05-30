namespace EXER02;
class Produto
{
    public string? Descricao {get;set;}
    public double Valor {get;set;}
    public double Importado {get;set;}

    public double calcularValor(double Valor){
        return Valor*1.1;

    }
}