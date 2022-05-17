public abstract class Conta
{
    private decimal saldo;
    private string titular;
    public abstract string Id { get; }

    public Conta(string t)
    {
        titular = t;
    }

    public decimal Saldo
    {
        get { return saldo; }
    }

    public string Titular
    {
        get { return titular; }
    }

   public virtual void Depositar(decimal valor)
    {
        saldo += valor;
    }


}