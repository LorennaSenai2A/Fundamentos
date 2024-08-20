using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        //atributos
        public string Nome { get; set; }
        //public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        //metodos
        public virtual void apresentarSe() { }
        public virtual void evoluir() { }
        public virtual int atacar()
        {
            int pontosAtaque = 0;
            pontosAtaque = (this.Inteligencia + (this.Forca * 2) + this.Agilidade + this.Nivel
                + this.Vida) / 6;
            return pontosAtaque;
        }
        public virtual int defender()
        {
            int pontosDefesa = 0;
            pontosDefesa = (this.Inteligencia + this.Forca + (this.Agilidade * 2) + this.Nivel
                + this.Vida) / 6;
            return pontosDefesa;
        }
        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.atacar();
                int valorDefesaInimigo = p.defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }

                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na vida do inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.atacar();
                int valorDefesa = this.defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na vida do atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do atacante é " + this.Vida);

                Console.WriteLine("========================");

                if(this.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + p.Nome + " venceu!");
                    vencedor = true;
                }
                if (p.Vida <= 0)
                {
                    Console.WriteLine("O personagem " + this.Nome + " venceu!");
                    vencedor = true;
                }
            }
        }
    }
}
