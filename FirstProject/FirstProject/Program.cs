using System;
using System.Globalization;

namespace uri1012 {
    class Program {
        static void Main(string[] args) {


            int numero = int.Parse(Console.ReadLine());
            // SEM O PARAMS
           int result = FirstProject.Model.Calculator.Sum(new int[] {numero});

            Console.WriteLine(  result );



            

        }

    }
}





















