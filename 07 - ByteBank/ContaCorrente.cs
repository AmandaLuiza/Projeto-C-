using System;
using _07_ByteBank2;

public class ContaCorrente
{
    public static double TaxaOperacao { get; private set; }

    public static int TotalDeContasCriadas { get; private set; }

    internal void SetAgencia(int v)
    {
        throw new NotImplementedException();
    }

    public Cliente Titular { get; set; }

    public int Numero { get; set; }

    private int _agencia;
    public int Agencia
     
    { 
        
            set
        {
            if (value <= 0)
            {
                return;
            }

            _agencia = value;
        }
    }

    private double _saldo = 100;
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 10)
            {
                return;
            }

            _saldo = value;
        }
    }

    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;

        TaxaOperacao = 30 / TotalDeContasCriadas;

        TotalDeContasCriadas++;
    }

    public bool Sacar(double valor)
    {
        if (_saldo < valor)
        {
            return false;
        }

        _saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (_saldo < valor)
        {
            return false;
        }

        _saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}