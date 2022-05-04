using System;
using System.Collections.Generic;
using System.Text;

namespace DuckUsingInterface
{
    abstract class Duck
    {

        public string nome { get; private set; }

        public Duck(string nome)
        {
            this.nome = nome;
        }

        abstract public void falar();

    }
}
