using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf, string nome) : base(cpf, 2000, nome)
        {
            TotalDeFunc++;
        }

        public override void AumentarSal()
        {
            Salario *= 1.1;
        }

        protected override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
