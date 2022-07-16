using System;

namespace T05Ejercicio5
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Escriba el número para convertir a binario:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número binario es: " + Binario(numero));
        }

        static String Binario(int numero)
        {
            String resultado = "";
            while (numero > 0)
            {
                int resto = numero % 2;
                numero = numero / 2;
                resultado = resto.ToString() + resultado;
            }
            return resultado;
        }
        //Existe otra forma más simple de realizar la conversión mediante:
        //return Convert.ToString(numero, 2);  

    }
}