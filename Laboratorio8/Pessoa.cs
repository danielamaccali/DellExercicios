public class Pessoa : IComparable<Pessoa>
{
    private string meuNome;
    private int minhaIdade;

    public Pessoa(string n, int i)
    {
        meuNome = n;
        minhaIdade = i;
    }

    public string Nome
    {
        get { return meuNome; }
    }
    
    public int Idade
    {
        get { return minhaIdade; }
        set { minhaIdade = value; }
    }

    /*public int CompareTo(Pessoa outro)
    {
        return meuNome.CompareTo(outro.meuNome);
    }*/

    //1. Altere o método CompareTo() da classe Pessoa para que a comparação seja realizada pela idade da pessoa em ordem crescente.

    public int CompareTo(Pessoa outro)
    {
        return minhaIdade.CompareTo(outro.minhaIdade);
    }

}