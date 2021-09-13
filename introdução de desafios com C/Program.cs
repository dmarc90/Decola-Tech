using System;
using System.Collections.Generic;
using System.Linq;
using static System.Boolean;

namespace desafios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multiplos();
            // NumerosImpares();
            // ConversaoTempo();
            // TrabalhoElfos();
            desafio();
        }


        private static void desafio()
        {
            int[] vetor = new int[20];
            IEnumerable<int> sequencia = Enumerable.Range(0,20);
            IEnumerable<int> sequencia2 = Enumerable.Range(0,20).Reverse();

            foreach (int c in sequencia)
            {
                vetor[c] = int.Parse(Console.ReadLine());
                
            }

            int k = 0;
            foreach (int j in sequencia2)
            {
            Console.WriteLine($"N[{k}] = {vetor[j]}");
            k++;
            }

        }






        private static void Multiplos()
        {
            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A ==0 ) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
        
            }
        }

        private static void NumerosImpares()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            //complete seu codigo
            for (int i=1; i<=n; i+=2) //complete seu codigo
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }

        private static void ConversaoTempo()
        {
            var timeInSeconds = int.Parse(Console.ReadLine());

            //continue a solucao
            var hours = timeInSeconds / (60*60);
            timeInSeconds =  timeInSeconds % (60*60);
            var minutes = timeInSeconds / 60;
            var seconds = timeInSeconds % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }

        private static void TrabalhoElfos()
        {
            string[] line1 = Console.ReadLine().Split(" ");
            string[] line2 = Console.ReadLine().Split(" ");
            
            int finalExpediente = int.Parse(line1[0]);
            
            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);
            
            //continue a solucao
            int totalNecessario =  presente1 + presente2;
            
            if (totalNecessario > finalExpediente)
            {
            Console.WriteLine("Deixa para amanha!");
            }
            else
            {
            Console.WriteLine("Farei hoje!");
             }
        }

    }

    
}


