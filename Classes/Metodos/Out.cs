using System;

namespace Classes.Metodos{

    public class Out{

        static void Dividir(int x, int y, out int resultado, out int resto){
            resultado = x / y;
            resto = x % y;
        }

        public static void Dividir(){
            Dividir(10, 3, out int result, out int rest);
            Console.WriteLine($"10 dividido por 3 é: {result} com resto {rest}");
        }
    }
}