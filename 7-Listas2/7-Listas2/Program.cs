using System;
using System.Collections.Generic;

namespace _7_Listas2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco"); //Adiciona o Marco na posição 2



        foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count); //Quantidade de valores na lista

            string s1 = list.Find(Test); // Espera um predicado como argumento e Find retorna a primeira aparição
            Console.WriteLine("First 'A': " + s1);

            //Também pode ser realizado com uma expressão lambda
            string s2 = list.Find(x => x[1] == 'l');
            Console.WriteLine("Usando lambda: " +s2);

            string s3 = list.FindLast(x => x[0] == 'A'); 
            Console.WriteLine("Última aparição: " + s3);

            int posicao1 = list.FindIndex(x => x[0] == 'A'); //Index da primeira aparição
            Console.WriteLine(posicao1);

            int posicao2 = list.FindLastIndex(x => x[0] == 'A'); //Index da ultima aparição
            Console.WriteLine(posicao2);

            List<string> list2 = list.FindAll(x => x.Length == 5); //Filtrar com base no predicado
            Console.WriteLine("----------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(3);
            list.RemoveRange(2, 2); //A partir da posição 2 remove dois itens
            list.Remove("Alex");
            Console.WriteLine("-------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
        static bool Test(string s)
        {
            return s[0] == 'A'; //Retorna verdadeiro se a primeira letra for A
        }
    }
}
