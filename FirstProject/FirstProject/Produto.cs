using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstProject {
    class Produto {

        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        /* Para o programa funcionar sem dados obrigatorios, é necessário fazer uma sobrecarda (criar  contrutor com mesmo
         * nome da classe mas sem parametros) */

        /* Caso queiramos que nosso programa não deixe altera o atributo dela, apenas fazemos o get do atributo.. Assim só é possivel
         * retornar o valor e não é possivel altera-la, pois o encapsulamento permite que você deixe os atributos private para que
         * outra classe não acesse, sendo assim só é possivel acessar pelos metodos getters e setters.
         *  */


        public Produto() {


        }


        //Properties são encapsulamentos iguais ao set e get, porém, a sintaxe é mais similar ao atributo e não é necessário
        // ficar chamando os sets e gets 
        public string Nome {

            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }

        }

       

      
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }




        public double TotalStock() {
            double totalStock;
            totalStock = Preco * Quantidade;
            return totalStock;

        }

        public void AddProduct(int quantidade) {

            Quantidade = Quantidade + quantidade;




        }

        public void RemoveProduct(int quantidade) {

            Quantidade = Quantidade - quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade + "unidades, Total: $"
                + TotalStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
