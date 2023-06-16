using CourseProjectImpost.Entities;
using System;
using System.Globalization;

namespace CourseProjectImpost
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> list = new List<TaxPayer>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (op == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, income, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, number));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach(TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name + ": $ " + tax.Tax().ToString("f2" ,CultureInfo.InvariantCulture));
            }
            Console.WriteLine();
            double sum = 0;
            foreach (TaxPayer tax in list)
            {
                sum += tax.Tax();
            }
            Console.WriteLine("Total Taxes: $ " + sum.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}