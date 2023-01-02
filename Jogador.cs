using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogaDaVelha {
    public class Jogador {

        public string Nome { get; set; }
        public int Vitorias { get; set; }
        public int Derrotas { get; set; }
        public int Empates { get; set; }

        public Jogador(string nome) { 
            this.Nome = nome;
        }
    }
}
