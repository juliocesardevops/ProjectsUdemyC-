using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Model {
    class ConversorMoeda {

        public static double iof = 6.0;


       

        public static double DolarParaReal(double cotacao, double dolares) {

            double total = dolares * cotacao;

            return total + total * iof / 100;

        }

    }
}
