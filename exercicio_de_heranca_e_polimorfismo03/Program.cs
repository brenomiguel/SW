namespace exercicio_de_heranca_e_polimorfismo03;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica pf = new ContratoPessoaFisica();
        ContratoPessoaJuridica pj = new ContratoPessoaJuridica();

        pf.Tipo = "Pessoa Física";
        pj.Tipo = "Pessoa Jurídica";
        pf.Idade = 40;
        pf.Cpf = 93472937520;
        pj.Cnpj = 93427504819;
        pj.Inscricao = 19509216817;
        pj.Prazo = 10;
        pf.Prazo = 10;
       
        Console.WriteLine("Contrato: " + pj.Tipo + "//CNPJ: " + pj.Cnpj + "||Inscrição estadual: " + pj.Inscricao + "||Valor do contrato: " + c.calcularPrestacao() + "||Prazo de pagamento: " + pj.Prazo + "||Valor das prestações: " + pj.calcularPrestacao());
        Console.WriteLine("Contrato: " + pf.Tipo + "//Idade: " + pf.Idade + "||CPF: " + pf.Cpf + "||Valor do contrato: " + c.calcularPrestacao() + "||Prazo de pagamento: "+ pf.Prazo + "||Valor das prestações: " + pf.calcularPrestacao());
        
        
    }
} 
