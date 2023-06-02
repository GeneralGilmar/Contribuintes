using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NContribuintes.Entities
{
    internal abstract class Person
    {

        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        protected Person()
        {
        }

        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
