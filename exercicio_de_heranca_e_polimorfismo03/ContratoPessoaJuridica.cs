namespace exercicio_de_heranca_e_polimorfismo03;
class ContratoPessoaJuridica:Contrato
{

public override double calcularPrestacao(){
    return ((base.calcularPrestacao()/Prazo)+3);
}

  
}