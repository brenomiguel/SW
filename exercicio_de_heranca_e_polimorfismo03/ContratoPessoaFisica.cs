namespace exercicio_de_heranca_e_polimorfismo03;
class ContratoPessoaFisica:Contrato
{
    public override double calcularPrestacao(){
        return ((base.calcularPrestacao()/prazo)+3);
    }


  
}