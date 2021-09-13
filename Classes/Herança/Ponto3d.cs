using System;


namespace Classes.Herança
{
    public class Ponto3d : Ponto
    {
        public int z;

        private double distancia3d;
        public Ponto3d(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia(x, y);
        }

        public static void Calcular()
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();

        }
    }
}