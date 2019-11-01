using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; set; }
        private string _cpf;
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }

        public string Profissao { get; set; }
        public static int Totaldeclientes{ get; private set; }

		//Construtor do objeto da classe.
        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            _cpf = cpf;
            Profissao = profissao;
            Totaldeclientes++;
        }
        public Cliente(string nome)
        {
            Nome = nome;
        }
		
		public override bool Equals(object obj)
		{
			Cliente cliente = obj as Cliente;
			
			if(cliente == null){return false;}
			
			return cliente.CPF == CPF;
		}
    }
}