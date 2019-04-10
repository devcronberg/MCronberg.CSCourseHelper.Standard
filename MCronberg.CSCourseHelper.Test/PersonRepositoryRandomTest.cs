using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCronberg.CSCourseHelper.Test
{
    [TestClass]
    public class PersonRepositoryRandomTest
    {
        [TestMethod]
        public void TestGetPeople()
        {
            MCronberg.PersonRepositoryRandom m = new PersonRepositoryRandom();
            var lst = m.GetPeople();
            Assert.IsTrue(lst.Count == 200);

            lst = m.GetPeople(5);
            Assert.IsTrue(lst.Count == 5);
        }

        [TestMethod]
        public void TestJustGetPeople()
        {

            var lst = MCronberg.PersonRepositoryRandom.JustGetPeople();
            Assert.IsTrue(lst.Count == 25);

            lst = MCronberg.PersonRepositoryRandom.JustGetPeople(10);
            Assert.IsTrue(lst.Count == 10);

        }


        [TestMethod]
        public void TestGetPerson()
        {
            MCronberg.PersonRepositoryRandom m = new PersonRepositoryRandom();
            var p = m.GetPerson(1);
            Assert.IsNotNull(p);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestAddPerson()
        {
            MCronberg.PersonRepositoryRandom m = new PersonRepositoryRandom();
            m.AddPerson(new Person());
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestDeletePerson()
        {
            MCronberg.PersonRepositoryRandom m = new PersonRepositoryRandom();
            m.DeletePerson(1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestUpdatePerson()
        {
            MCronberg.PersonRepositoryRandom m = new PersonRepositoryRandom();
            var p = m.GetPerson(1);
            m.UpdatePerson(p);
        }
        
    }
}
