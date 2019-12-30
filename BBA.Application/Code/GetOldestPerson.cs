using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetOldestPerson : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 8"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            var oldestPerson = people.OrderByDescending(p => p.Age).First();

            return oldestPerson.GivenName;
        }
    }
}
