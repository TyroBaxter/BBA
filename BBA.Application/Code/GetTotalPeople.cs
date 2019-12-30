using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetTotalPeople : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 1"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {

            return people.Count.ToString();
        }
    }
}
