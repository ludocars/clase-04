using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHangManGame {
    class Program {
        static void Main (string[] args) {
            //asignacion de variables
            string secretword = "zapatos";
            string publicword = "";
            string letter = "";
            int hp = 3;
            string tempword = "";
            
            //PROCESOS:

            for (int i = 0; i < secretword.Length; i++) {
                tempword += "*"; 
            }
            publicword = tempword;
            Console.WriteLine (publicword);

            while (hp > 0) {
                Console.WriteLine ("HP = " + hp);
                Console.WriteLine ("ingrese una letra: ");
                letter = Console.ReadLine();
                Console.Clear ();

                tempword = "";
                for (int i=0; i < secretword.Length; i++) {
                    if (letter == "" + secretword[i]) {
                        tempword += letter;
                    }
                    else {
                        tempword += publicword[i];
                    }
                }
                if (publicword == tempword) {
                    hp--;
                }
                if (secretword == tempword) {
                    Console.WriteLine ("YOU WIN!");
                    break;
                }
                publicword = tempword;
                Console.WriteLine (publicword);
            }
            if (hp <= 0) {
                Console.WriteLine ("GAME OVER");
            }
            Console.ReadLine();
        }
    }
}
    //foreach (char c in secretword) {
                //    if (letter == "" + c) {
                //        tempword += c; //tempword = temoword + c; suma a tempword el caracter "c"
                //  } else {
                //        tempword += "*";
                //    }
     // Console.WriteLine (secretword.Length); cuenta la cantidad de letras en la palabra secreta
       // Console.WriteLine("> \t"+letter) muestra la letra que se ingreso