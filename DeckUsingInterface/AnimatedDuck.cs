using System;
using System.Collections.Generic;
using System.Text;

namespace DuckUsingInterface
{
    class AnimatedDuck : Duck, ISabeVoar
    {
        


        public AnimatedDuck(string nome) : base(nome)
        {
        }

        public override void falar()
        {
            Console.WriteLine("O " + this.nome + " sabe falar!");
        }

        public void sabeVoar()
        {
            Console.WriteLine("O " + this.nome + " sabe voar!");
        }
    }
}
