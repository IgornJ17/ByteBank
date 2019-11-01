using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas_Internos;

namespace ByteBank.Funcionarios
{
    public abstract class  FuncionarioAutenticavel : Funcionario, IAutenticavel
    {

        public string Senha { get; set; }

        public FuncionarioAutenticavel(string cpf, double salario, string nome) 
            : base(cpf, salario, nome)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
