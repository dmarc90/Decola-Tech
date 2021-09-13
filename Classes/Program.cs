using System;
using Classes.Herança;
using Classes.Metodos;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(5, 10);

            p1.CalcularDistancia(10, 10);

            Ref.Inverter();

            Out.Dividir();

        }
    }
}
