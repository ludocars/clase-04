using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame {
    class Program {
        static void Main (string[] args) {
            //asignacion de variables
            string secretword = "zapato";
            string letter = "";
            int hp = 3;

            //procesos
            for (int i = 0; i < secretword.Length; i++) {
                Console.Write ("*");
            }
            Console.WriteLine ();

            // Console.WriteLine (secretword.Length); cuenta la cantidad de letras en la palabra secreta
            Console.WriteLine ("ingrese la letra: \n");
            letter = Console.ReadLine ();
            
            // Console.WriteLine("> \t"+letter) muestra la letra que se ingreso

            Console.ReadLine(); //evita el cierre del programa
        }
    }
}
