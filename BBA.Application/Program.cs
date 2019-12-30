using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBA.Application.Code;

namespace BBA.Application
{
    //some changes here 
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new PersonLoader();
            var answers = new Answers();

            var people = loader.LoadPeopleFromFile();

           // Console.WriteLine("A1: There are {0} people", GetTotalPeople.GetAnswer(people));
            //Console.WriteLine("A2: There are {0} pieces of data", answers.GetAmountOfData(people));
            //Console.WriteLine("A3: There are {0} men", answers.GetNumberOfMen(people));
            //Console.WriteLine("A4: There are {0} married women", answers.GetNumberOfMarriedWomen(people));
            //Console.WriteLine("A5: There most populated state is {0} ", answers.GetMostPopulatedState(people));
            //Console.WriteLine("A6: The heaviest person is {0}", answers.GetHeaviestPerson(people));
            //Console.WriteLine("A7: The lightest person is {0}", answers.GetLightestPerson(people));
            //Console.WriteLine("A8: The oldest person is {0}", answers.GetOldestPerson(people));
            //Console.WriteLine("A9: The most popular vehicle year is {0}", answers.GetMostPopularVehicleYear(people));

            Console.ReadLine();
        }
    }
}
