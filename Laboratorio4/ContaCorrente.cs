using System;

class ContaCorrente
{
    private string nomeTitular {get; set; }
    private DateTime dataCriacao { get; init; }
    private decimal saldo;

    public ContaCorrente(decimal val)
    {
        saldo = val;
    }
    
    public ContaCorrente(string nomeTitular, DateTime dataCriacao, decimal saldo)
    {
        nomeTitular = nomeTitular;
        dataCriacao = dataCriacao;
        saldo = saldo;
    }

    public void Depositar(decimal val)
    {
        saldo = saldo + val;
    }

    public void Sacar(decimal val)
    {
        saldo = saldo - val;
    }

    public decimal Saldo
    {
        get { return saldo; }
    }


}