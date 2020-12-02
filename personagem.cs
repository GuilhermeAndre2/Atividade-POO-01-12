using System;
namespace Aula_2___POO
{
    public class personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string IA;

        public int vida = 100;
        public int Ataque1(){
            return 100;
        }

        public int Ataque2(){
            return 20;
        }

        public int defesa(int Ataque){

            this.vida = this.vida - Ataque;

            return this.vida = this.vida - Ataque;
        }
        
    }
}