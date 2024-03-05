using System;
class Program
    {
        static void Main()
        {
            int n1, n2, n3, n4, n5;
            Console.Write("Ingrese numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            n4 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            n5 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero: ");
            int numero = n1*10000 + n2*1000 + n3*100 + n4*10 + n5; 
            int ultimoNumero = numero % 10;
            numero /= 10;
            int resultado = ultimoNumero * (int)Math.Pow(10, Math.Floor(Math.Log10(numero) + 1)) + numero;
            Console.WriteLine(resultado);
            Console.ReadLine();   
            
            
            /*
            Console.Write("Ingrese la palabra 'Murcielago': ");
            String animal = Console.ReadLine().ToLower();
            int contar = 0; 

            foreach (char vocales in animal)
            {
                if (vocal(vocales))
                {
                    contar++;
                }           
            }            
            Console.WriteLine($"La palabra '{animal}' tiene {contar} vocales");           
            static bool vocal(char vocales)
            {
                return "aeiouáéíóú".Contains(vocales);
            } 

            Console.ReadLine();   
            */ 
            /*

            Console.Write("Ingrese la palabra 'Hola mundo': ");
            String palabra = Console.ReadLine().ToLower();
            int contar = 0;

            foreach (char letras in palabra)
            {
                if (letra(letras))
                {
                    contar++;
                }
            }
            Console.WriteLine($"la palabra '{palabra}' tiene {contar} letras");
            static bool letra (char letras)
            {
                return "abcdefghijklmnopqrstuvwxyz".Contains(letras);
            }
            Console.ReadLine();
            */
        }   
    }
