namespace JogaDaVelha {
    public class Program {
        static void Main(string[] args) {
         
            Jogo jogoDaVelha = new Jogo();

            

            Jogador jogador1 = new Jogador("Vicente");
            Jogador jogador2 = new Jogador("Ana");



            do {
                Console.Clear();
                jogoDaVelha.Apresentar();
                Console.WriteLine($"Rodada {jogoDaVelha.tentativas + 1}º vez {jogoDaVelha.TurnoAtual()}"); 
                Console.WriteLine("selecione uma casa de 1 a 9");
                int casa = int.Parse(Console.ReadLine());
                while (jogoDaVelha.VerificarvalorDaCasa(casa)) {
                    Console.WriteLine("Valor invalido digite novamente!!");
                    casa = int.Parse(Console.ReadLine());
                }
                jogoDaVelha.SelecionarCasa(casa);
                jogoDaVelha.Rodadas();
                
                
            } while (jogoDaVelha.tentativas < 9);



        }
    }
}