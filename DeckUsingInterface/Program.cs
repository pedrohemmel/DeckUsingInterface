using System;
using System.Collections.Generic;

namespace DuckUsingInterface
{
    class Program
    {

        public static List<T> CopiaApos<T>(List<T> lista, int indexCorte)
        {

            int contador = Math.Min(indexCorte, lista.Count);
            List<T> ret = new List<T>();

            for (int i = contador; i < lista.Count; i++)
            {
                ret.Add(lista[i]);
            }

            return ret;

        }
        static void Main(string[] args)
        {
            MallardDuck patoHenrique = new MallardDuck("Pato Henrique");
            AnimatedDuck patoRobert = new AnimatedDuck("Pato Robert");
            RubberDuck patoWellinston = new RubberDuck("Pato Wllinston");

            patoWellinston.sabeComer();
            Console.WriteLine("\n");
            patoRobert.sabeVoar();
            Console.WriteLine("\n");
            patoHenrique.sabeVoar();
            Console.WriteLine("\n"); 
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            patoHenrique.falar();
            Console.WriteLine("\n");
            patoRobert.falar();
            Console.WriteLine("\n");
            patoWellinston.falar();

            Console.WriteLine("\n"); 
            Console.WriteLine("\n");

            List<int> listaFeita = new List<int>();
            listaFeita.Add(10);
            listaFeita.Add(20);
            listaFeita.Add(30);
            listaFeita.Add(40);
            listaFeita.Add(50);
            listaFeita.Add(60);
            listaFeita.Add(70);
            listaFeita.Add(80);
            listaFeita.Add(90);
            listaFeita.Add(100);
            listaFeita.Add(110);

            List<int> novaLista = CopiaApos<int>(listaFeita, 3);

            foreach(int list in novaLista) {
                Console.WriteLine(list);
            }


        }
    }
}
