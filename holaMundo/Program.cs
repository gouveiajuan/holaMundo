using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Menu();
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Que quieres hacer?" + "\nIngresa:" + "\n(a) para dividir | " +
                "(b) para media | (c) para convertir frase en Camel Case |" + "\n(d) para comparar dos fechas |" +
                " (f) para comprobar si una palabra es Palindromo | " + "\n(g) para calcular la potencia de dos numeros |" +
                " (h) para invertir una cifra |" + "\n(i) para tambien invertir una cifra | (j) Para adivinar un numero |" +
                "\n(k) Para comparar dos palabras");
            string menu = Console.ReadLine().ToLower();
            menu = menu.ToLower();

            switch (menu)
            {
                case "a":
                    Division();
                    break;
                case "b":
                    Media();
                    break;
                case "c":
                    CamelCase();
                    break;
                case "d":
                    Fechas();
                    break;
                case "f":
                    Palindromo();
                    break;
                case "g":
                    Potencia();
                    break;
                case "h":
                    InvertirNumero();
                    break;
                case "i":
                    InvertirCifra();
                    break;
                case "j":
                    Adivinanza();
                    break;
                case "k":
                    Cadenas();
                    break;
            }
        }
        static void Division()
        {
            Console.WriteLine("Vamos a dividir, ingresa el primer numero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(" ingresa el segundo numero");
            int deno = int.Parse(Console.ReadLine());
            int cociente = 0;

            while (deno == 0)
            {
                Console.WriteLine("no puedes ingresar 0, ingresa otro numero");
                deno = int.Parse(Console.ReadLine());
            }

            while (num >= deno)
            {
                cociente += 1;
                num -= deno;
            }
            Console.Write("el resultado es ");
            Console.WriteLine(cociente);
            Console.ReadKey();
        }
        static void Media()
        {
            Console.WriteLine("Vamos a calcular la media");
            Console.WriteLine("Ingresa un numero");
            uint nume = uint.Parse(Console.ReadLine());
            uint sum = nume;
            uint contador = 0;
            while (nume != 0)
            {
                Console.WriteLine("ingresa otro numero");
                nume = uint.Parse(Console.ReadLine());
                sum += nume;
                contador++;

            }
            Console.WriteLine("La media es:");
            uint media = sum / contador;
            Console.WriteLine(media);
            Console.ReadKey();
        }
        static void CamelCase()
        {
            Console.WriteLine("Escribe una frase");
            string frase1 = Console.ReadLine();
            char[] fraseArray = frase1.ToCharArray();
            int posicion = 0;
            string resultado = "";
            foreach (char e in fraseArray)
            {
                resultado += e;
                if (e == ' ')
                    fraseArray[posicion + 1] = char.ToUpper(fraseArray[posicion + 1]);

                posicion++;
            }
            resultado = resultado.Replace(" ", "");
            Console.WriteLine("La frase convertida a CamelCase:");
            Console.Write(resultado);
            Console.ReadKey();
        }

        static void Fechas()
        {
            Console.WriteLine("Compararemos dos fechas, vamos con la primera fecha: Escribe el dia");
            uint dia1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el mes");
            uint mes1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el año");
            uint ano1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Vamos con la segunda fecha Escribe el dia");
            uint dia2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el mes");
            uint mes2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el año");
            uint ano2 = uint.Parse(Console.ReadLine());

            if (ano1 == ano2)
                if (mes1 == mes2)
                    if (dia1 == dia2)
                        Console.WriteLine("ambas fechas son iguales");
                    else if (dia1 < dia2)
                        Console.WriteLine("la primera fecha va antes");
                    else
                        Console.WriteLine("la segunda fecha va antes");
                else if (mes1 < mes2)
                    Console.WriteLine("la primera fecha va antes");
                else
                    Console.WriteLine("la segunda fecha va antes");
            else if (ano1 < ano2)
                Console.WriteLine("la primera fecha va antes");
            else
                Console.WriteLine("la segunda fecha va antes");

            Console.ReadKey();
        }

        static void Palindromo()
        {
            Console.WriteLine("Vamos a comprobar si una palabra es Palindromo, escribe una palabra");
            string palabra = Console.ReadLine();
            int longitud = palabra.Length;
            int contador = 0;
            bool comprobador = true;
            palabra = palabra.ToLower();

            for (int i = longitud - 1; i >= 0; i--)
            {
                if (palabra[i] != palabra[contador])
                {
                    comprobador = false;
                    break;
                }
                contador++;
            }
            if
                (comprobador == true)
            {
                Console.WriteLine("Es un palindromo");
                Console.ReadKey();
            }
            else
                Console.WriteLine("No es un palindromo");
            Console.ReadKey();
        }
        static void Potencia()
        {
            Console.WriteLine("Vamos a calcular la potencia de dos numeros" + "\ningresa el primer número");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero");
            int num2 = int.Parse(Console.ReadLine());
            int resultado = 0;

            for (int i = 0; i < num2; i++)
            {
                resultado = num * num;
            }
            Console.WriteLine("la potencia es " + resultado);
            Console.ReadKey();
        }

        static void InvertirNumero()
        {
            Console.WriteLine("Vamos a invertir una cifra" + "\nIngresa la cifra");
            string cifra = Console.ReadLine();
            char[] cifra2 = cifra.ToCharArray();

            for (int i = cifra.Length - 1; i >= 0; i--)
            {
                Console.Write(cifra2[i]);
            }
            Console.ReadKey();
        }

        static void InvertirCifra()
        {
            Console.WriteLine("Vamos a invertir una cifra" + "\nIngresa la cifra");
            int numero = int.Parse(Console.ReadLine());

            int resultado = 0;
            while (numero > 0)
            {
                resultado = resultado * 10 + numero % 10;
                numero /= 10;
            }
            Console.WriteLine(resultado);
            Console.ReadKey();
        }

        static void Adivinanza()
        {
            Console.WriteLine("Adivina el numero entre 1 y 20");
            int numero1 = int.Parse(Console.ReadLine());
            Random aleatorio = new Random();
            int numero2 = aleatorio.Next(1, 20);

            while (numero1 != numero2)
            {
                if (numero1 > numero2)
                    Console.WriteLine("Debes Ingresar un numero menor");
                else
                    Console.WriteLine("Debes ingresar un numero mayor");

                numero1 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Muy bien, has adivinado");
            Console.ReadKey();
        }
        static void Cadenas()
        {
            Console.WriteLine("Vamos a comprobar cadenas");
            Console.WriteLine("Escribe la primera palabra");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Escribe la segunda palabra");
            string palabra2 = Console.ReadLine();

            char[] comprobacion1 = palabra1.ToCharArray();
            char[] comprobacion2 = palabra1.ToCharArray();
            bool resultado1 = false;
            bool resultado2 = false;
            bool? resultado3 = null;


            if (palabra1.Length < palabra2.Length)
            {
                for (int i = 0; i <= palabra1.Length-1; i++)
                {
                    if (comprobacion1[i] > comprobacion2[i])
                        resultado1 = true;
                    //Console.WriteLine(palabra2 + " Va antes que " + palabra1);
                    else if (comprobacion2[i] > comprobacion1[i])
                        resultado2 = true;
                    //Console.WriteLine(palabra1 + " Va antes que " + palabra2);
                }
            }

            else if (palabra2.Length < palabra1.Length)
            {
                for (int i = 0; i <= palabra2.Length - 1; i++)
                {
                    if (comprobacion1[i] > comprobacion2[i])
                        resultado1 = true;
                    //Console.WriteLine(palabra2 + " Va antes que " + palabra1);
                    else if (comprobacion2[i] > comprobacion1[i])
                        resultado2 = true;
                }
            }
            else if (palabra2.Length == palabra1.Length)
            {
                for (int i = 0; i < palabra2.Length; i++)
                {
                    if (comprobacion1[i] > comprobacion2[i])
                        resultado1 = true;
                    //Console.WriteLine(palabra2 + " Va antes que " + palabra1);
                    else if (comprobacion2[i] > comprobacion1[i])
                        resultado2 = true;
                    //Console.WriteLine(palabra1 + " Va antes que " + palabra2);
                    else if (i == palabra2.Length-1)
                        resultado3 = true;
                }
            }

            if (resultado1 == true)
                Console.WriteLine(palabra2 + " Va antes que " + palabra1);
            else if (resultado2 == true)
                Console.WriteLine(palabra1 + " Va antes que " + palabra2);
            else if (resultado3 == true)
                Console.WriteLine("Son iguales");
            else Console.WriteLine("AAAAAA");
            

            Console.ReadKey();
        }
    }
}