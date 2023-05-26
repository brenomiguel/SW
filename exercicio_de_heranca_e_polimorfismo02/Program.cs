namespace exercicio_de_heranca_e_polimorfismo02;
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
        
        
        Console.WriteLine("Tipo de contrato: " + pj.Tipo + " //CNPJ: " + pj.Cnpj + " ||Inscrição estadual: " + pj.Inscricao);
        Console.WriteLine("Tipo de contrato: " + pf.Tipo + " //Idade: " + pf.Idade + " ||CPF: " + pf.Cpf);
        
    }
} 
