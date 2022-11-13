using bytebank.Contas;
using bytebank.Titular;

Cliente contaCliente = new Cliente("João", "123.456.789-10", "Programador");
ContaCorrente conta = new ContaCorrente(contaCliente, 123, "321-X");

Cliente contaCliente2 = new Cliente("Maria", "321.654.987-01", "Programadora");
ContaCorrente conta2 = new ContaCorrente(contaCliente2, 321, "123-X");

conta.Depositar(100); // 100
conta.Sacar(50); // 100 - 50 = 50
conta.Transferir(25, conta2); //50 - 25 = 25
Console.WriteLine(conta.GetSaldo()); // Depois de todas as operações o saldo dá conta ficará: 25
Console.WriteLine(conta2.GetSaldo()); // conta2 agora tem 25 de saldo