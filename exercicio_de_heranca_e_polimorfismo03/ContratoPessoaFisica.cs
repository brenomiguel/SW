namespace exercicio_de_heranca_e_polimorfismo03;
class ContratoPessoaFisica:Contrato
{

public override double calcularPrestacao(){
    if (Idade <= 30)
    {
        return ((base.calcularPrestacao()/Prazo)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.calcularPrestacao()/Prazo)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.calcularPrestacao()/Prazo)+3);
    }
    else 
    {
        return ((base.calcularPrestacao()/Prazo)+4);
    }
}
  
}