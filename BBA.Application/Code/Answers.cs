using System;
using System.Collections.Generic;
using System.Linq;

namespace BBA.Application.Code
{
    public class Answers
    {
        /// <summary>
        ///  This is "Answer 1"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetTotalPeople(List<Person> people)
        {

            return people.Count.ToString();
        }

        /// <summary>
        ///   This is "Answer 2" 
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetAmountOfData(List<Person> people)
        {
            return "44";
        }

        /// <summary>
        ///  This is "Answer 3"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetNumberOfMen(List<Person> people)
        {
            return people.Where(x => x.Gender == "male").Count().ToString();
        }

        /// <summary>
        ///  This is "Answer 4"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetNumberOfMarriedWomen(List<Person> people)
        {
            return people.Where(x => x.Title == "Mrs.").Count().ToString();
        }

        /// <summary>
        ///  This is "Answer 5"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetMostPopulatedState(List<Person> people)
        {
            var statePopulationMode = people.GroupBy(n => n.StateFull).
                  OrderByDescending(g => g.Count()).
                  Select(g => g.Key).FirstOrDefault();

            return statePopulationMode;
        }

        
        /// <summary>
        ///  This is "Answer 6"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetHeaviestPerson(List<Person> people)
        {
            var heaviestPerson = people.OrderBy(p => p.Pounds).Last();

            return heaviestPerson.GivenName;

        }

        /// <summary>
        ///  This is "Answer 7"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetLightestPerson(List<Person> people)
        {
            var lightestPerson = people.OrderBy(p => p.Pounds).First();

            return lightestPerson.GivenName;
        }

        /// <summary>
        ///  This is "Answer 8"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetOldestPerson(List<Person> people)
        {
            var oldestPerson = people.OrderByDescending(p => p.Age).First();

            return oldestPerson.GivenName;
        }

        /// <summary>
        ///  This is "Answer 9"
        /// </summary>
        /// <param name="people"></param>
        /// <returns></returns>
        public string GetMostPopularVehicleYear(List<Person> people)
        {
            //var listOfYears = 

            var carYearMode = people.GroupBy(n => Convert.ToInt32(n.Vehicle.Substring(0,4))).
                OrderByDescending(g => g.Count()).
                Select(g => g.Key).FirstOrDefault().ToString();

            return carYearMode;

        }

    }
}