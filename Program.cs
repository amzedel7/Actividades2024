using System;

namespace ActividadEnClase
{
    class Program
    {
        static void Main(string[] args)
        {
        string animal = "Murcielago";
        int contar = 0;

        foreach (char letra in animal)
        {
            if (char.IsLetter(letra))
            {
                contar++;
            }
        } 
        console.writeline($"hola{contar}");   
        }   
    }
}