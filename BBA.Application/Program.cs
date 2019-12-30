using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBA.Application.Code;
using StructureMap;

namespace BBA.Application
{
    //some changes here 
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new PersonLoader();
            var answers = new List<IPeopleAnswerer>
            {
                new GetAmountOfData(), new GetHeaviestPerson(), new GetLightestPerson(),
                new GetMostPopularVehicleYear(), new GetMostPopulatedState(), new GetNumberOfMarriedWomen(),
                new GetNumberOfMen(), new GetOldestPerson(), new GetTotalPeople()
            };
            var ioc = new Container();
            ioc.Configure(c => c.Scan(s =>
            {
                s.TheCallingAssembly();
                s.RegisterConcreteTypesAgainstTheFirstInterface();

            }));

            var answers2 = ioc.GetAllInstances<IPeopleAnswerer>();

            var people = loader.LoadPeopleFromFile();

            foreach (var answer in answers)
            {
                Console.WriteLine(answer.GetAnswer(people));
            }

            Console.ReadLine();
        }
    }
}
