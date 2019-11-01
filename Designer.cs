using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Designer : Funcionario
    {

        public Designer(string cpf, string nome): base(cpf, 3000, nome)
        {
            TotalDeFunc++;
        }

        public override void AumentarSal()
        {
            Salario *= 1.11;
        }

        protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
