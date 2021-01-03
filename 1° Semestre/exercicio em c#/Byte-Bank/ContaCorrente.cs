namespace Byte_Bank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _Saldo = 0.0;


        public double Saldo
        {
            get { return _Saldo; }
            set {_Saldo = value; }

        }


        public double Saque { get; set; }
        public double Valor { get; set; }

        public ContaCorrente(Cliente titular, int agencia, int numero)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            this._Saldo = 0.0;

        }

        public double Depositoo(double Valor)
        {


            return this._Saldo += Valor;



        }

        public bool saque(double Valor)
        {
            if (Saldo > Valor)
            {
                _Saldo -= Valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool transferencia(ContaCorrente contadestino, double Valor)
        {
            if (this.saque(Valor))
            {
                contadestino.Depositoo(Valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}