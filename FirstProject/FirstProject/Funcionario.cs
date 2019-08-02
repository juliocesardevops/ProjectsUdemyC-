using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace FirstProject {
    class Funcionario {

        public string Nome;
        public double SalarioBruto;
        public double imposto;


        public double CalculaSalarioLiquido() {


            return SalarioBruto - imposto;

        
            
        }

        public void AlteraSalario(double porcentagemMain) {

            
            SalarioBruto = SalarioBruto + (SalarioBruto  * porcentagemMain / 100);
            

        }

        public override string ToString() {
            return Nome
                + ", R$"
                + CalculaSalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);





            }
    }
}
