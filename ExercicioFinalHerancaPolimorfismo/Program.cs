using System;
using System.Collections.Generic;
using ExercicioFinalHerancaPolimorfismo.Entities;

namespace ExercicioFinalHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numberTaxPayers = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberTaxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");

                Console.Write("Individual or company (i / c)?: ");
                char c = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (c == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));

                }

                else
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberEmployees));

                }


            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach(TaxPayer t in taxPayers)
            {
                Console.WriteLine(t);
            }

        }
    }
}
