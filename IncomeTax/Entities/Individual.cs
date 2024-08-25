using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstract.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double helthExpeditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = helthExpeditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Payer name: {Name}");
            Console.WriteLine($"Tax: {Tax():C}");
        }
    }
}