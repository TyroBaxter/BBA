using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetNumberOfFloridians : IPeopleAnswerer
    {
        public string GetAnswer(List<Person> people)
        {
            var numFloridians = people.Where(x => x.StateFull == "Florida").Count().ToString();

            return numFloridians;
        }
    }
}
