using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public interface IPeopleAnswerer
    {
        string GetAnswer(List<Person> people);
    }
}
