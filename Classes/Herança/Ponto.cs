using System;

namespace Classes.Herança
{
    public class Ponto
    {
        public int x, y;
        private double distancia;
        
        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void CalcularDistancia(int x, int y)
        {
            //Faz alguma coisa...

            Console.WriteLine(CalcularDistancia2(x,y));
        }

        private double CalcularDistancia2(int x, int y)
        {
            //Faz alguma coisa...
            this.distancia = Math.Sqrt(Math.Pow((this.x - x), 2)) + Math.Sqrt(Math.Pow((this.y - y), 2));
            return this.distancia;
        }

        public virtual void CalcularDistancia3()
        {
            //Faz alguma coisa...
        }
    }
}