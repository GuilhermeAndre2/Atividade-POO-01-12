using System;

namespace Aula_2___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando Objeto

            personagem Player1 = new personagem();
            Player1.nome = "Guilherme";
            Player1.idade = 20;
            Player1.armadura = "Face-Shield";

            personagem Player2 = new personagem();
            Player2.nome = "Tony Stark";
            Player2.idade = 40;
            Player2.armadura = "MK3";

            
            Console.WriteLine($"Jogador 1 = {Player1.nome} | idade = {Player1.idade} | Armadura = {Player1.armadura}");
            Console.WriteLine("                             VS                                                      ");
            Console.WriteLine($"Jogador 2 = {Player2.nome} | idade = {Player2.idade} | Armadura = {Player2.armadura}");

            Console.WriteLine();
            int vidaDoJogador2 = Player2.defesa(Player2.Ataque1());

            if(vidaDoJogador2 <= 0){
                Console.WriteLine("Player2 Perdeu !");
            }else{
                Console.WriteLine($"Vida do Player 2 após ataque = {Player2.vida}%");   
            } 
        }
    }
}
