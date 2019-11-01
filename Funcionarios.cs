using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        static public int TotalDeFunc { get; protected set; }

        public Funcionario(string cpf, double salario, string nome)
        {
            CPF = cpf;
            Salario = salario;
            Nome = nome;
            TotalDeFunc++;

        }
        
        public abstract void AumentarSal();

        internal protected abstract double GetBonificacao();
    }
}
