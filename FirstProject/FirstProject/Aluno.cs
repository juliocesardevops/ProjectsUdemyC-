using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Model {
    class Aluno {
        public string Nome;
        public double Nota_1;
        public double Nota_2;
        public double Nota_3;


        public double MediaAluno() {

            double media = (Nota_1 + Nota_2 + Nota_3) / 3;

            return media;
        }

        public void CalculoVerificarAluno() {

            if (MediaAluno() >= 60) {
                Console.WriteLine("APROVADO!");

            }
            if (MediaAluno() <= 60) {
                Console.WriteLine(" REPROVADO!");
                Console.WriteLine("FALTARAM "+ (60 - MediaAluno())+" PONTOS");
            }

        }
        //FEITA DEPOIS DE PRONTO
        public bool AprovadoOuReprovado() {
                if(MediaAluno()>= 60.0) {

                return true;
            }
            else {

                return false;
            }   

        }

        public double notaRestante() {
            if (AprovadoOuReprovado()) {
                return 0.0;

            }
            else {
                return 60.0 - MediaAluno();
            }

        }

    }

        
}
