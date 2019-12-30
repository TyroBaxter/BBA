using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetLightestPerson : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 7"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            var lightestPerson = people.OrderBy(p => p.Pounds).First();

            return lightestPerson.GivenName;
        }
    }
}
