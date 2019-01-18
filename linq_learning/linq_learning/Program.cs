using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace linq_learning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            // here we are overwriting the list with an ordered list
            // we can chain ordering functions with ThenBy or ThenByDescending
            //people = people.OrderByDescending(x => x.LastName).ThenBy(x=>x.YearsExperience).ToList();

            //people = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 3).ToList();



            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience {person.YearsExperience}");
            //}

            //int yearsTotal = people.Sum(x => x.YearsExperience);
            int experienceOfMarchBirthdays = 0;

            experienceOfMarchBirthdays = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience);

            //Console.WriteLine("The total years experience is: {0}.", yearsTotal);
            Console.WriteLine("The March experience is: {0}.", experienceOfMarchBirthdays);
            Console.ReadLine();
        }
    }
}
