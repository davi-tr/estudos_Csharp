using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudos.Models
{
    internal class Pessoa
    {
        public String Nome { get; set; }
        public int Idade { get; set; }
        
        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e eu tenho {Idade}");
        }
    }
}
