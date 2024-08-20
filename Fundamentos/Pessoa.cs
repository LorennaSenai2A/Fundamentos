using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Pessoa
    {
        //ATRIBUTOS
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Envelhecer(int anos)
        {
            this.Idade += anos;
            Console.WriteLine(this.Nome + " sua idade agora é " + this.Idade);

        }
    }
}
