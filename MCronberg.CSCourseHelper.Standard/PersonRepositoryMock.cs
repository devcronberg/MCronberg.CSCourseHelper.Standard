using System;
using System.Collections.Generic;
using System.Linq;

namespace MCronberg
{
    public class PersonRepositoryMock : IPersonRepository
    {

        public static List<Person> JustGetPeople(int count = 25)
        {
            return new PersonRepositoryMock().GetPeople().Take(count).ToList();
        }

        public void AddPerson(Person p)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            
        }

        public List<Person> GetPeople()
        {
            List<Person> p = new List<Person>();
            for (int i = 1; i <= 200; i++)
            {
                p.Add(new Person() { PersonId = i, FirstName = "MockPerson", LastName = "#" + i, DateOfBirth = new DateTime(2019, 1, 1), Gender = Gender.Male, Height = 180, IsHealthy = true });
            }
            return p;
        }

        public List<Person> GetPeople(int count)
        {

            return GetPeople().Take(count).ToList();
        }

        public Person GetPerson(int id)
        {
            return GetPeople()[0];
        }

        public void UpdatePerson(Person p)
        {
            throw new NotImplementedException();
        }
    }
}