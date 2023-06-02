using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NContribuintes.Entities
{
    internal class Individual : Person
    {

        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome,double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }


        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return AnnualIncome * 0.15 - HealthExpenditures*0.5;

            }
            else
            {
                return AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }

        public override string ToString()
        {
            return $" {Name}: $ {Tax().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
