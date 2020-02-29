using System;

namespace Aula_27___2 {
    class Program {
        static void Main(string[] args) {

            int hora =int.Parse(DateTime.Now.ToString("HH"));
            string horaCheia = DateTime.Now.ToShortTimeString(); 
            
            if (hora >= 6 && hora < 12) {
                Console.WriteLine("Bom dia, são " + horaCheia + " Horas");
            }

            else if (hora >= 12 && hora < 18) {
                Console.WriteLine("Boa tarde, são " + horaCheia + " Horas");
            }

            else {
                Console.WriteLine("Boa noite, são " + horaCheia + " Horas");
            }

        }
    }
}
