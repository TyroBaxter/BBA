using System;
using System.Collections.Generic;
using BBA.Application.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BBA.Tests
{
    public abstract class AnswersTestBase<T> where T:new()
    {
        protected readonly List<Person> people = new List<Person>();
        protected readonly T subject = new T();
    }

    [TestClass]
    public class When_getting_the_first_answer : AnswersTestBase<GetTotalPeople>
    {
        private string result;

        public When_getting_the_first_answer()
        {
            people.Add(new Person());
            people.Add(new Person());
            people.Add(new Person());
            people.Add(new Person());
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("4", result);
    }

    [TestClass]
    public class When_getting_the_second_answer : AnswersTestBase<GetAmountOfData>
    {
        private string result;

        public When_getting_the_second_answer()
        {
            people.Add(new Person());
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("44", result);
    }

    [TestClass]
    public class When_getting_the_third_answer_with_good_data : AnswersTestBase<GetNumberOfMen>
    {
        private string result;

        public When_getting_the_third_answer_with_good_data()
        {
            people.Add(new Person { Gender = "male" });
            people.Add(new Person { Gender = "female" });
            people.Add(new Person { Gender = "male" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("2", result);
    }

    [TestClass]
    public class When_getting_the_third_answer_with_bad_data : AnswersTestBase<GetNumberOfMen>
    {
        private string result;

        public When_getting_the_third_answer_with_bad_data()
        {
            people.Add(new Person { Gender = "female" });
            people.Add(new Person { Gender = "female" });
            people.Add(new Person { Gender = "" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("0", result);
    }

    [TestClass]
    public class When_getting_the_fourth_answer_with_good_data : AnswersTestBase<GetNumberOfMarriedWomen>
    {
        private string result;

        public When_getting_the_fourth_answer_with_good_data()
        {
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "Mrs." });
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "Mrs." });
            people.Add(new Person { Title = "Ms." });
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "Mrs." });
            people.Add(new Person { Title = "Ms." });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("3", result);
    }

    [TestClass]
    public class When_getting_the_fourth_answer_with_bad_data : AnswersTestBase<GetNumberOfMarriedWomen>
    {
        private string result;

        public When_getting_the_fourth_answer_with_bad_data()
        {
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "" });
            people.Add(new Person { Title = "Ms." });
            people.Add(new Person { Title = "Mr." });
            people.Add(new Person { Title = "Mrs." });
            people.Add(new Person { Title = "Ms." });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("1", result);
    }

    [TestClass]
    public class When_getting_the_fifth_answer_with_good_data : AnswersTestBase<GetMostPopulatedState>
    {
        private string result;

        public When_getting_the_fifth_answer_with_good_data()
        {
            people.Add(new Person { StateFull = "Alabama" });
            people.Add(new Person { StateFull = "Texas" });
            people.Add(new Person { StateFull = "Kansas" });
            people.Add(new Person { StateFull = "Texas" });
            people.Add(new Person { StateFull = "Missouri" });
            people.Add(new Person { StateFull = "Texas" });
            people.Add(new Person { StateFull = "Texas" });
            people.Add(new Person { StateFull = "Missouri" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.AreEqual("Texas", result);
    }

    [TestClass]
    public class When_getting_the_fifth_answer_with_bad_data : AnswersTestBase<GetMostPopulatedState>
    {
        private string result;

        public When_getting_the_fifth_answer_with_bad_data()
        {
            people.Add(new Person { StateFull = "Alabama" });
            people.Add(new Person { StateFull = "Texas" });
            people.Add(new Person { StateFull = "Kansas" });
            people.Add(new Person { StateFull = "Missouri" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_count_the_people() => Assert.IsFalse(string.IsNullOrEmpty(result));   // there isn't a correct answer in this case, so any answer is right
    }

    [TestClass]
    public class When_getting_the_sixth_answer : AnswersTestBase<GetHeaviestPerson>
    {
        private string result;

        public When_getting_the_sixth_answer()
        {
            people.Add(new Person { Pounds = 181, GivenName = "Susan" });
            people.Add(new Person { Pounds = 208, GivenName = "Ricky" });
            people.Add(new Person { Pounds = 146, GivenName = "Morty" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_return_a_person() => Assert.IsNotNull(result);

        [TestMethod]
        public void It_should_return_the_right_person() => Assert.AreEqual("Ricky", result);
    }

    [TestClass]
    public class When_getting_the_seventh_answer : AnswersTestBase<GetLightestPerson>
    {
        private string result;

        public When_getting_the_seventh_answer()
        {
            people.Add(new Person { Pounds = 181, GivenName = "Susan" });
            people.Add(new Person { Pounds = 208, GivenName = "Ricky" });
            people.Add(new Person { Pounds = 146, GivenName = "Morty" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_return_a_person() => Assert.IsNotNull(result);

        [TestMethod]
        public void It_should_return_the_right_person() => Assert.AreEqual("Morty", result);
    }

    [TestClass]
    public class When_getting_the_eighth_answer : AnswersTestBase<GetOldestPerson>
    {
        private string result;

        public When_getting_the_eighth_answer()
        {
            people.Add(new Person { Age = 88, GivenName = "Susan" });
            people.Add(new Person { Age = 45, GivenName = "Ricky" });
            people.Add(new Person { Age = 72, GivenName = "Morty" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_return_a_person() => Assert.IsNotNull(result);

        [TestMethod]
        public void It_should_return_the_right_person() => Assert.AreEqual("Susan", result);
    }

    [TestClass]
    public class When_getting_the_ninth_answer : AnswersTestBase<GetMostPopularVehicleYear>
    {
        private string result;

        public When_getting_the_ninth_answer()
        {
            people.Add(new Person { Vehicle = "2006 Ferrari La Crapperosa" });
            people.Add(new Person { Vehicle = "2003 Honda Grey thing" });
            people.Add(new Person { Vehicle = "2006 Ford Scootypuff Sr." });
            people.Add(new Person { Vehicle = "2010 Ferrari La Crapperosa" });
            people.Add(new Person { Vehicle = "2005 Chevy Rapmobile" });
        }

        [TestInitialize]
        public void Because() => result = subject.GetAnswer(people);

        [TestMethod]
        public void It_should_return_the_right_person() => Assert.AreEqual("2006", result);
    }
}
