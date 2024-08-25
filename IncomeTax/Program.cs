using MetodosAbstract.Entities;
using System.Globalization;
using System.Net.Http.Metrics;
using System.Numerics;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of tax payers: ");
        int numPayers = int.Parse(Console.ReadLine()!);

        List<TaxPayer> list = new List<TaxPayer>(); 

        for (int payer = 1; payer <= numPayers; payer++)
        {
            Console.WriteLine();
            Console.WriteLine($"Tax payer #{payer} data: ");
            Console.Write("Individual or Company (i/c): ");
            char opcao = char.Parse(Console.ReadLine()!);
            Console.Write("Name: ");
            string name = Console.ReadLine()!;
            Console.Write("Anual Income: ");
            double anualIncome = double.Parse(Console.ReadLine()!);
            switch (opcao) 
            {
                case 'i':
                    Console.Write("Health expeditures: ");
                    double helthExpedi = double.Parse(Console.ReadLine()!);
                    list.Add(new Individual(helthExpedi, name, anualIncome));
                    break;

                case 'c':
                    Console.Write("Number of Employees: ");
                    int numEmp = int.Parse(Console.ReadLine()!);
                    list.Add(new Company(numEmp, name, anualIncome));
                    break;

            
            }

        }

        Console.WriteLine();
        double sum = 0;
        Console.WriteLine("Taxes Paid: ");
        foreach (TaxPayer taxPayer in list)
        {
            Console.WriteLine();
            double tax = taxPayer.Tax();
            taxPayer.ExibirInfo();
            sum += tax;            
        }

        Console.WriteLine();
        Console.WriteLine($"Total Taxes: {sum:C}");
    }
}