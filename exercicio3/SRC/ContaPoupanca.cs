namespace exercicio3.SRC
{
    public class ContaPoupanca:  Conta , IcalcularImposto
    {
        public ContaPoupanca(int numero, string titular, double saldo)
        {
            this.numero = Numero;
            this.titular = Titular;
            this.saldo = Saldo;
        }
        private int numero;

        private string titular;

        private double saldo;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

      Conta.RendimentoMesal(double saldo)
      {
          Saldo= Saldo* 0.05;
      }

       public void CalcularImposto(double Saldo)
        {
            Saldo= saldo();
        }

    }
}