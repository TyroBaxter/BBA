﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetAmountOfData : IPeopleAnswerer
    {
        /// <summary>
        ///   This is "Answer 2" 
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            return "44";
        }
    }
}
