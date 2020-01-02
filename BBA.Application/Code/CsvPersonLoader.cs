using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class CsvPersonLoader : IPersonLoader
    {
        private readonly ICsvLocator _csvLocator;
        public CsvPersonLoader(ICsvLocator csvLocator)
        {
            _csvLocator = csvLocator;
        }
        public List<Person> LoadPeople()
        {
            var path = _csvLocator.Path;


        }

        private Person CovertDataIntoObject()
        {
            //consume data from various sources and convert into Person object
            return new Person();
        }


    }
}
