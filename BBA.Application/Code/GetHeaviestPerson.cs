﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBA.Application.Code
{
    public class GetHeaviestPerson : IPeopleAnswerer
    {
        /// <summary>
        ///  This is "Answer 6"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAnswer(List<Person> people)
        {
            Console.WriteLine($"There are {people.Count} people");

            var heaviestPerson = people.OrderBy(p => p.Pounds).Last();

            return heaviestPerson.GivenName;

        }
    }
}
