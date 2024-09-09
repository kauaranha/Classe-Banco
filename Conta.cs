using System;
namespace ContaCorrente
{
    public class Conta
    {
      
        private int saldo;

        public Conta()
        {
            this.Nome = "Kauã";
            this.SaldoInicial = 0;
            ExibirSaldo();
        }

        public int SaldoInicial
        {
            get { return this.saldo; }
            set { this.saldo = value; }
        }

        private String nome_cliente;
        public String Nome
        {
            get { return this.nome_cliente; }
            set { this.nome_cliente = value.ToUpper(); }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Nome : " + this.Nome);
            Console.WriteLine("Saldo Na conta : " + this.SaldoInicial);
        }

        public string InsereSaldo(double ValorInserido)
        {
            SaldoInicial =  SaldoInicial + Convert.ToInt32(ValorInserido);
            return "O valor foi inserido com sucesso!";
        }

        public void SacaValores(double ValorASerSacado)
        {
            if(ValorASerSacado > SaldoInicial){
                Console.WriteLine("Saldo insuficiente na conta!");  
            } else {
               SaldoInicial -= Convert.ToInt32(ValorASerSacado); 
                Console.WriteLine("Valor sacado com Sucesso!");   
            }
        }

    }
}
