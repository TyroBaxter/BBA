using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetMostPopulatedState : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 5"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            var statePopulationMode = people.GroupBy(n => n.StateFull).
                  OrderByDescending(g => g.Count()).
                  Select(g => g.Key).FirstOrDefault();

            return statePopulationMode;
        }
    }
}
