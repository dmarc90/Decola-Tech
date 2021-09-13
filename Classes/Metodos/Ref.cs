using System;

namespace Classes.Metodos{

    public class Ref{

        static void Inverter(ref int x, ref int y){
        int temp = x;
        x = y;
        y = temp;
    }

        public static void Inverter()
    {
        int i = 1, j =2;

        Inverter(ref i, ref j);
        Console.WriteLine($"{i} --- {j}");

    }

    }
    
    
}