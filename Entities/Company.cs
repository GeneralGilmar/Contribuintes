using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NContribuintes.Entities
{
    internal class Company:Person
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;

        }

        public override double Tax()
        {
            if(NumberEmployees >   10)
            {
                return AnnualIncome * 0.14;

            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
        public override string? ToString()
        {
            return $" {Name}: $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}"; ;
        }

        
    }
}
