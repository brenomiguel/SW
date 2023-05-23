namespace exercicio_de_heranca_e_polimorfismo03;
class Contrato

{
   public string? Tipo {get;set;}

   public long Cpf {get;set;}

   public int Idade {get;set;}

   public long Inscricao {get;set;}

   public long Cnpj {get;set;}

   public virtual double calcularPrestacao(){
      return 1000;
   }


}
