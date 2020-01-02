using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetMostPopularVehicleYear : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 9"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            Console.WriteLine($"There are {people.Count} people");

            var carYearMode = people.GroupBy(n => Convert.ToInt32(n.Vehicle.Substring(0, 4))).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault().ToString();
            
            return carYearMode;

        }
    }
}
