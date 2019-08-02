using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject.Model.Vetores {
    class Pensionato {
        public string Name { get; set; }
        public string Email { get; set; }


        public Pensionato(string name, string email) {
            Name = name;
            Email = email;
         
        }
        public override string ToString() {
            return Name + " , " + Email;



        }
    }
}
