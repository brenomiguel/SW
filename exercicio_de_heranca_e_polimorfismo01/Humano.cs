namespace exercicio_de_heranca_e_polimorfismo01;
class Humano:Animal
{
    public override string Fala()
    {
        return base.Fala() + "oi"; 
    }
}
