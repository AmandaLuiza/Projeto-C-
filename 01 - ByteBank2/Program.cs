using System;

namespace _01___ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
            new ContaCorrente2();

            ContaCorrente2 contaDaGabriela = new ContaCorrente2();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo " + contaDaGabriela.saldo);


            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo " + contaDaGabriela.saldo);


            Console.ReadLine();
    }
  }
}