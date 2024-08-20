using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Elfo : Personagem
    {
        public override void apresentarSe()
        {
            Console.WriteLine("Halora, adoro pregar peças e ser vitorioso sempre, sou conhecido como "
                + this.Nome + " tenho " + this.Vida + " pontos de vida. \nInteligência: "
                + this.Inteligencia + "\nAgilidade: " + this.Agilidade + "\nForca: " + this.Forca
                + "\nMeu nível atual é: " + this.Nivel);
            Console.WriteLine("========================");
        }
    }
}
