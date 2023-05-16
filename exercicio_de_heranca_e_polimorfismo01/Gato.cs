namespace exercicio_de_heranca_e_polimorfismo01;
class Gato:Animal 
{
    public override string Fala()
    {
        return base.Fala() + "miau miau"; 
    }
}
