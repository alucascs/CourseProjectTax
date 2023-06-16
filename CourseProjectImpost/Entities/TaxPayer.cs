using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectImpost.Entities
{
     abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIcome { get; set; }

        protected TaxPayer(string name, double anualIcome)
        {
            Name = name;
            AnualIcome = anualIcome;
        }

        public abstract double Tax();
    }
}
