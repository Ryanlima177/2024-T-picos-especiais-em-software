using System;

class Program
{
    static void Main(string[] args)
    {
        // Inicializa a variável para contar a quantidade de vezes que alguém defecou
        int totalDefecacoes = 0;

        // Loop para pedir a quantidade de defecações para cada dia do mês
        for (int dia = 1; dia <= 22; dia++)
        {
            Console.Write($"Informe a quantidade de vezes que você defecou no dia {dia}: ");
            int defecacoesDia;
            
            // Tratamento de erro para garantir que seja fornecido um valor inteiro
            while (!int.TryParse(Console.ReadLine(), out defecacoesDia))
            {
                Console.WriteLine("Por favor, insira um número inteiro válido.");
                Console.Write($"Informe a quantidade de vezes que você defecou no dia {dia}: ");
            }

            // Adiciona a quantidade de defecações do dia ao total
            totalDefecacoes += defecacoesDia;
        }

        // Exibe o total de defecações no mês
        Console.WriteLine($"No total, você defecou {totalDefecacoes} vezes este mês.");
    }
}

