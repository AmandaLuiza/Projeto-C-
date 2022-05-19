using System;

namespace _02___ByteBank
{
    class Program
    {
        private static ContaCorrente contaDaGabriela;

        static void Main(string[] args)
        {
            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863456;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);
            


        }
    }
}
