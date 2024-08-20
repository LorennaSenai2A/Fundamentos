using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Animal
    {
        // Declaração de um atributo
        public string Especie { get; set; }
        public string Nome { get; set; }
        // Decaração de um metodo
        public abstract void emitirSom();
    }

}
