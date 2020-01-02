using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public interface ICsvLocator
    {
        string Path { get; }
    }

    public class HardCodedCsvLocator : ICsvLocator
    {
        public string Path => @"C:\Users\flemi\Source\Repos\BBA\BBA.Application\Documents\namedata.csv";
    }
}
