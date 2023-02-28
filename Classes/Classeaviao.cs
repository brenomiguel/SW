namespace classes;
class Classeaviao
{
    public string modelo;
    public int velocidade;
    public int altitude;
    public string marca;

    public void reduzir(){
        velocidade = false;
    }
    public void acelerar(){
        velocidade = true;
    }
    public void subir(){
        altitude = true;
    }
    public void descer(){
        altitude = false;
    }

}