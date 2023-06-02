

using NContribuintes.Entities;
using System.Globalization;

Console.Write("Enter the number of tax payers: ");
int t= int.Parse(Console.ReadLine());


List<Person> list = new List<Person>();

for(int i=0; i<t; i++)
{
    Console.WriteLine($"Tax payer #{i+1} data:");
    Console.Write("Individual or company (i/c)? ");
    string s= Console.ReadLine();

    Console.Write("Name: ");
    string name= Console.ReadLine();

    Console.Write("Anual Income: ");
    double annualIncome=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    if( s == "i")
    {
        Console.Write("Health expenditures: ");
        double he=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


        list.Add(new Individual(name,annualIncome,he));
    }
    else
    {
        Console.Write("Number of employees: ");
        int n = int.Parse(Console.ReadLine());

        list.Add(new Company(name,annualIncome,n));
    }

}

double total = 0;
foreach(Person person in list)
{

    Console.WriteLine(person);

    total += person.Tax();

}

Console.WriteLine($"TOTAL TAXES: $ {total}");

