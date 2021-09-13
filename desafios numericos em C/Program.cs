using System;
using System.Globalization;

namespace desafiosnumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            // TipoCombustivel();
            // OMaior();
            // ValidacaoNota();
            // TiposTriangulo();
            // SequenciaLogica2();
            CoordenadasPonto();
        }

        private static void CoordenadasPonto()
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }

        private static void SequenciaLogica2()
        {
            string[] vet = Console.ReadLine().Split(' ');
           
            //complete o código com sua solução
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            for (int i = 1; i <= y; i++)
            {
                Console.Write(i);
                if (i%x == 0)
                {
                    Console.WriteLine( );
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }

        private static void TiposTriangulo()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);
            OrdenaTresValores(a, b, c, out double a2, out double b2, out double c2);
            


              //continue a solucao
            if (a2>=b2+c2)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if ( a2*a2 == (b2*b2 + c2*c2))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a2*a2 > (b2*b2 + c2*c2))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a2*a2 < (b2*b2 + c2*c2))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if ((a2 == b2) && (b2 == c2))
                Console.WriteLine("TRIANGULO EQUILATERO");
            else if ((a2 == b2) || (b2 == c2))
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }

  
        private static void OrdenaTresValores(double a, double b, double c,
                                                out double a2, out double b2, out double c2)
        {
            double tempMaior;
            if(a < b){
                tempMaior = b;
                b = a;
                a = tempMaior;
                if(a > c){
                   if(c > b){ //bca
                       tempMaior = c;
                       c = b;
                       b = tempMaior;
                   } // bac
                } else {
                    tempMaior = c;
                    c = b;
                    b = a;
                    a = tempMaior;
                }
            } else if(a < c){ //cab
                tempMaior = c;
                c = b;
                b = a;
                a = tempMaior;
            } else if(b < c){ // acb
                tempMaior = c;
                c = b;
                b = tempMaior;
            }
            a2 = a;
            b2 = b;
            c2 = c;
        }

        private static void ValidacaoNota()
        {
            int contador=0;
            double soma=0;
            while(contador <2)
            {
                double valueRead = Convert.ToDouble(Console.ReadLine());
                if(valueRead>=0 && valueRead<=10){
                    soma += valueRead;
                    contador++;
                }
                else{
                    Console.WriteLine("nota invalida");
                }
            }
            Console.WriteLine("media = {0:0.00}",(soma/contador));

        }

        private static void OMaior()
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int MAIORAB = (Int32.Parse(vet[0]) + Int32.Parse(vet[1]) + Math.Abs(Int32.Parse(vet[0])-Int32.Parse(vet[1])))/2;

            int MAIOR = (MAIORAB+ Int32.Parse(vet[2]) + Math.Abs(MAIORAB - Int32.Parse(vet[2]))) / 2;

            Console.WriteLine($"{MAIOR} eh o maior");
        }


        private static void TipoCombustivel()
        {
            int opcao;
            int alcool = 0, gasolina = 0, diesel = 0;
            do
            {
                opcao = Convert.ToInt32(Console.ReadLine());    
                switch (opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;    
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        Console.WriteLine("MUITO OBRIGADO");
                        Console.WriteLine("Alcool: "+alcool);
                        Console.WriteLine("Gasolina: "+gasolina);
                        Console.WriteLine("Diesel: "+diesel);
                        break;
                    default:                       
                        continue;
                }
            }
       
            while (opcao != 4);
        }












    }
}
