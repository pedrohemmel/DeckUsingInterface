using System;
using System.Collections.Generic;
using System.Text;

namespace DuckUsingInterface
{
    class RubberDuck : Duck, ISabeComer
    {
        public RubberDuck(string nome) : base(nome)
        {
        }

        public override void falar()
        {
            Console.WriteLine("O " + this.nome + " sabe falar!");
        }

        public void sabeComer()
        {
            Console.WriteLine("O " + this.nome + " sabe comer!");
        }
    }
}
