using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Modelos
{
        public class SaldoInsuficienteException : OperacaoFinanceiraException
        {
            public double Saldo { get; }
            public double Saque { get; }
			
            public SaldoInsuficienteException() { }

            public SaldoInsuficienteException(double saldo, double valorSaque)
                : this($"Saque não permitido, valor do saque ultrapassa seu saldo. Saldo Atual: {Saldo}")
            {
                Saldo = saldo;
                Saque = valorSaque;
            }
            public SaldoInsuficienteException(string msg)
                : base(msg) { }
			
			public SaldoInsuficienteException(string msg, Exception excecaoInterna){}
        }
}
