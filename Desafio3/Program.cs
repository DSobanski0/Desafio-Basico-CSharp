using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String vertebradoInvertebrado;
            String especie;
            String habitoAlimentar;

            vertebradoInvertebrado = Console.ReadLine(); //insira suas variaveis
            especie = Console.ReadLine();
            habitoAlimentar = Console.ReadLine();

            if ((vertebradoInvertebrado == "vertebrado") && (especie == "ave") && (habitoAlimentar == "carnivoro"))
            {
                Console.WriteLine("aguia\n");
            }

            else if ((vertebradoInvertebrado == "vertebrado") && (especie == "ave") && (habitoAlimentar == "onivoro"))
            {
                Console.WriteLine("pomba\n");
            }

            else if ((vertebradoInvertebrado == "vertebrado") && (especie == "mamifero") && (habitoAlimentar == "onivoro"))
            {
                Console.WriteLine("homem\n");
            }

            else if ((vertebradoInvertebrado == "vertebrado") && (especie == "mamifero") && (habitoAlimentar == "herbivoro"))
            {
                Console.WriteLine("vaca\n");
            }

            else if ((vertebradoInvertebrado == "invertebrado") && (especie == "inseto") && (habitoAlimentar == "hematofago"))
            {
                Console.WriteLine("pulga\n");
            }

            else if ((vertebradoInvertebrado == "invertebrado") && (especie == "inseto") && (habitoAlimentar == "herbivoro"))
            {
                Console.WriteLine("lagarta\n");
            }

            else if ((vertebradoInvertebrado == "invertebrado") && (especie == "anelideo") && (habitoAlimentar == "hematofago"))
            {
                Console.WriteLine("sanguessuga\n");
            }

            else if ((vertebradoInvertebrado == "invertebrado") && (especie == "anelideo") && (habitoAlimentar == "onivoro"))
            {
                Console.WriteLine("minhoca\n");
            }
        }
    }
}
