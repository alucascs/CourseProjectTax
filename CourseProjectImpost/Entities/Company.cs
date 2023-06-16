using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectImpost.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double income, int numberOfEmployees) : base(name, income)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax;
            if(NumberOfEmployees > 10)
            {
                tax = AnualIcome * 0.14;
            }
            else
            {
                tax = AnualIcome * 0.16;
            }
            return tax;
        }
    }
}
