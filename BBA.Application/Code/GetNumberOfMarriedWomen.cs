using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetNumberOfMarriedWomen : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 4"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            return people.Where(x => x.Title == "Mrs.").Count().ToString();
        }
    }
}
