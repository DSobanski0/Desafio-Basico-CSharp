using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consumo do veículo
            var consumo = 12;

            // Dados de entrada - tempo gasto e velocidade média 
            string[] entrada = Console.ReadLine().Split(' ');
            int tempoGasto = int.Parse(entrada[0]);
            int velocidadeMedia = int.Parse(entrada[1]);

            // Cálculo da distância
            double distancia = velocidadeMedia * tempoGasto;

            // Cálculo da quantidade de litros utilizados
            double litrosCombustivel = distancia / consumo;

            // Resultado do programa
            Console.WriteLine(litrosCombustivel.ToString("N3"));
        }
    }
}
