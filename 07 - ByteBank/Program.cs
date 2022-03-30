using System;

class Program
{
    static void Main(string[] args)
    {
        //ContaCorrente conta = ContaCorrente(545, 788545);

        Metodo();

        Console.WriteLine("Execução finalizada. Tecle enter para sair");
        Console.ReadLine();
    }

    //private static ContaCorrente ContaCorrente(int v1, int v2)
    //{
        //throw new NotImplementedException();
    //}

    private static void Metodo()
    {
        TestaDivisao(0);
    }

    private static void TestaDivisao(int divisor)
    {
        int resultado = Dividir(10, divisor);
        Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
    }

    private static int Dividir(int numero, int divisor)
    {
        try
        {
            return numero / divisor;
        }
        
        catch (DivideByZeroException)
        {
            Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
            throw;
        }
    }
}