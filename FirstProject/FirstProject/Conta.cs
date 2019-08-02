using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace FirstProject.Model {
    class Conta {



        public string TitularConta { get; private set; }
        public int NumeroConta { get; set; }
        public double Saldo { get; private set; }

        // Para mais segurança é imprecindivel que se constrole os atributos com private set , e na hora de pedir ao 
        // usuário para carregar na tela, usar uma variavel temporaria.

        public Conta(string titularConta, int numeroConta) {
            TitularConta = titularConta;
            NumeroConta = numeroConta;
        }

        public Conta(string titularConta, int numeroConta, double depositoInicial) : this(titularConta, numeroConta) {
            realizaDeposito(depositoInicial);
        }



        public double realizaDeposito(double deposito) {

            if (deposito == 0) {
                Console.WriteLine("Não é possível realizar depositos de " + deposito + " reais, seu saldo não foi alterado");

                return Saldo;
            }

            return Saldo = deposito + Saldo;

        }

        public double realizaSaque(double saque) {

            if (saque == 0) {
                Console.WriteLine("Não é possível realizar saques de " + saque + " reais, seu saldo não foi alterado");

                return Saldo;
            }

            return Saldo = Saldo - saque - 5;

        }



        public override string ToString() {
            return "Conta: " + NumeroConta + ", "
                + " Nome: " + TitularConta + ", "
                + " Saldo : R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);



        }

    }







}

