using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas_Internos;

namespace ByteBank.Funcionarios
{
     public class Diretor : FuncionarioAutenticavel
    {


        public Diretor(string cpf, string nome) : base(cpf, 5000, nome)
        {
            TotalDeFunc++;
        }

        public override void AumentarSal()
        {
            Salario *= 1.15;
        }
        protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }
    }
}

