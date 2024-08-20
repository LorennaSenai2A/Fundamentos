using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Olá, sou o mago mais poderoso das terras, conhecido como "
                + this.Nome + " tenho " + this.Vida + " pontos de vida. \nInteligência: "
                + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForca: " + this.Forca
                + ". \nMeu nível atual é: " + this.Nivel);
            Console.WriteLine("========================");
        }
    }
}
