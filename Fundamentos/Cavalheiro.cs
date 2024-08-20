using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Cavalheiro : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Prazer, seria um honra trabalhar ao seu lado nessa luta, sou conhecido como "
                            + this.Nome + " tenho " + this.Vida + " pontos de vida. Inteligência: "
                            + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForca: " + this.Forca
                            + "\nMeu nível atual é: " + this.Nivel);
            Console.WriteLine("========================");
        }
    }
}
