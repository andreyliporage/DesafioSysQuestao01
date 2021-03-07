using System;
using System.Collections.Generic;

namespace DesafioSysQuestao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Questao01();
        }

        private static void Questao01()
        {
            var listaConsole = new List<int>();
            List<int> listaResultado = new List<int>();

            Console.Write("Alvo: ");
            var alvo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o tamanho do array: ");
            var tamanhoArray = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os números do array (digite um número e aperte enter): ");
            
            CriaListaInt(tamanhoArray, listaConsole);

            RetornaSomaAlvo(listaConsole, alvo);
        }

        private static void CriaListaInt(int tamanhoArray, List<int> listaConsole)
        {
            for (int i = 0; i < tamanhoArray; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                listaConsole.Add(numero);
            }
            listaConsole.Sort();
        }

        private static void RetornaSomaAlvo(List<int> listaConsole, int alvo)
        {
            List<int> listaResultado = new List<int>();
            for (int i = 0; i < listaConsole.Count; i++)
            {
                if(listaConsole[i] + listaConsole[i + 1] == alvo)
                {
                    listaResultado.Add(i);
                    listaResultado.Add(i + 1);
                    Console.WriteLine($"[{i}, {i + 1}]");
                    break;
                }
            }
        }
    }
}
