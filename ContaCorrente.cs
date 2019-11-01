using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Modelos
{
    public class ContaCorrente
    {

        public int Ag { get; } 
        public int Cc { get; }
        public static double TaxaDeOperacao{ get; set; } 
        public Cliente Titular { get; set; }
        public static int TotalDeContas { get; private set; }
        public int ContadorSaquesnaoPermitidos {get; private set;}
        public int ContadorTransferenciasnaoPermitidas{get; private set;}

        private decimal _saldo = 500;
        //defindo as regras dos acessadores para o campo de armazenamento _saldo.
        public decimal Saldo
        {
            get
            {
                return _saldo;
            }
            set{

              //Verifica a validade do valor definido para inclusão no campo de armazenamento saldo.
              
              if (value < 0)
              {
                 return;
              }

                _saldo = value;
            }
        }
        public ContaCorrente(int ag, int cc, string nome)
        {
            //verificando se agencia e conta são valores válidos. Caso não seja, será lançada uma exceção.
            if (ag <= 0)
            {
                Exception excecao = new ArgumentException("Não é permitido a criação de conta com a agência zerada ou com valor negativo.");
                throw excecao;
            }
            if (cc <= 0)
            {
                Exception excecao = new ArgumentException("Não é permitido a criação de conta corrente zerada ou com valor negativo.");
                throw excecao;
            }

            Ag = ag;
            Cc = cc;
            Cliente titular = new Cliente(nome);
            Titular = titular;
            TotalDeContas++;
            
            try
            {
                TaxaDeOperacao = 30 / TotalDeContas;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }

        }

        //public ContaCorrente(int cc) : this(490, cc) 
       // {
            //referenciando o construtor de cima primeiro.
       // }
        
        
        public void Sacar(decimal valor)
        {
            if (valor > _saldo)
            {
                ContadorSaquesnaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }
            if(valor < 0){
                throw new ArgumentException($"Saque não permitido.\nSaldo menor que o valor do Saque.\nSaldo atual: {_saldo}" );
            }
            _saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            _saldo += valor;
        }

        public void Transferir(decimal valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor da tranferencia é inválido: " + valor);
            }

            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasnaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação inválida." , ex);
            }
            contaDestino.Depositar(valor);
           
        }

        public decimal ObterSaldo()
        {
            return _saldo;
        }
		
		//Retorna os dados do cliente criado atraves do método ToString da classe base Object.
		public override string ToString()
		{
			return $"Esta conta é do cliente {Titular.Nome} da agência {Ag} e conta {Cc}"
		}
    }

}