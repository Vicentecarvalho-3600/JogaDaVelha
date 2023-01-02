using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace JogaDaVelha {
    public class Jogo {

        private string[,] matriz = new string[3, 3];
        private string turno = "X";
        public int tentativas = 0;
        
        public Jogo() {
            int index = 1;
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    matriz[i, j] = index.ToString();
                    index++;
                }
            }
        
        }


        public void Apresentar() {
            for (int i = 0; i < matriz.GetLength(0); i++) {
                for (int j = 0; j < matriz.GetLength(1); j++) {
                    Console.Write($"|{matriz[i, j]}|");
                }
            Console.WriteLine();
            }
        }

        public void SelecionarCasa(int numero) {
            int casa = numero ;
            switch (casa) {
                case 1:
                    matriz[0, 0] = turno;
                    break;
                case 2:
                    matriz[0, 1] = turno;
                    break;
                case 3:
                    matriz[0, 2] = turno;
                    break;
                case 4:
                    matriz[1, 0] = turno;
                    break;
                case 5:
                    matriz[1, 1] = turno;
                    break;
                case 6:
                    matriz[1, 2] = turno;
                    break;
                case 7:
                    matriz[2, 0] = turno;
                    break;
                case 8:
                    matriz[2, 1] = turno;
                    break;
                case 9:
                    matriz[2, 2] = turno;
                    break;
            }
        }

        public void AlternarTurno() {
            if (turno == "X") {
                turno = "O";
            } else {
                turno = "X";
            }
        }

        public void Rodadas() {
            tentativas++;
            AlternarTurno();
        }

        public bool VerificarvalorDaCasa(int numero) {
            bool condicao;
            int casa = numero;
            if (casa > 9 || casa < 1) {
                condicao = true;
            }else {
                condicao= false;
            }
            return condicao;
        }
        
        public string TurnoAtual() {
            return turno;
        } 

        public void ImprimirGanhador() {
            Console.WriteLine($"O {turno} ganhou");
        }


        public void VerificarDiagonal() {
            if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] ||
                 matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]) {
                ImprimirGanhador();
            }
        }



    }
}
