using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas_Internos;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf, string nome) : base(cpf, 4000, nome)
        {
            TotalDeFunc++;
        }

        public override void AumentarSal()
        {
            Salario *= 1.05;
        }

        protected override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
