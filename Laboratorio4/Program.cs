ContaCorrente minhaConta = new ContaCorrente("Fulano de Tal", DateTime.Now, 1000);
Console.WriteLine(minhaConta.Saldo);
minhaConta.Depositar(100);
Console.WriteLine(minhaConta.Saldo);
minhaConta.Sacar(50);
Console.WriteLine(minhaConta.Saldo);

// COMPLEMENTAR A SOLUÇÃO