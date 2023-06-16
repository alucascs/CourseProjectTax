using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectImpost.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double income, double healthExpenditures) : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax;
            if (AnualIcome < 20000.00)
            {
                tax = AnualIcome * 0.15;
            }
            else
            {
                tax = AnualIcome * 0.25;
            }
            if(HealthExpenditures > 0)
            {
                tax -= HealthExpenditures / 2;
            }
            return tax;
        }
    }
}
