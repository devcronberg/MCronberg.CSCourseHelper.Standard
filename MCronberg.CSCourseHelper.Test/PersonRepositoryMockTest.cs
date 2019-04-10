using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCronberg.CSCourseHelper.Test
{
    [TestClass]
    public class PersonRepositoryMockTest
    {
        [TestMethod]
        public void TestGetPeople()
        {
            MCronberg.PersonRepositoryMock m = new PersonRepositoryMock();
            var lst = m.GetPeople();
            Assert.IsTrue(lst.Count == 200);

            lst = m.GetPeople(5);
            Assert.IsTrue(lst.Count == 5);

            Assert.IsTrue(lst[0].PersonId == 1);
            Assert.IsTrue(lst[0].Name == "MockPerson #1");
        }

        [TestMethod]
        public void TestJustGetPeople()
        {

            var lst = MCronberg.PersonRepositoryMock.JustGetPeople();
            Assert.IsTrue(lst.Count == 25);

            lst = MCronberg.PersonRepositoryMock.JustGetPeople(10);
            Assert.IsTrue(lst.Count == 10);

            Assert.IsTrue(lst[0].PersonId == 1);
            Assert.IsTrue(lst[0].Name == "MockPerson #1");
        }


        [TestMethod]
        public void TestGetPerson()
        {
            MCronberg.PersonRepositoryMock m = new PersonRepositoryMock();
            var p = m.GetPerson(1);
            Assert.IsTrue(p.PersonId == 1);
            Assert.IsTrue(p.Name == "MockPerson #1");
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestAddPerson()
        {
            MCronberg.PersonRepositoryMock m = new PersonRepositoryMock();
            m.AddPerson(new Person());            
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestDeletePerson()
        {
            MCronberg.PersonRepositoryMock m = new PersonRepositoryMock();
            m.DeletePerson(1);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotImplementedException))]
        public void TestUpdatePerson()
        {
            MCronberg.PersonRepositoryMock m = new PersonRepositoryMock();
            var p = m.GetPerson(1);
            m.UpdatePerson(p);
        }

    }
}
