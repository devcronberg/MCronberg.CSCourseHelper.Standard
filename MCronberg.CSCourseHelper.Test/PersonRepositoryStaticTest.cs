using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCronberg.CSCourseHelper.Test
{
    [TestClass]
    public class PersonRepositoryStaticTest
    {
        MCronberg.PersonRepositoryStatic m = new PersonRepositoryStatic();

        [TestMethod]
        public void TestGetPeople()
        {            
            var lst = m.GetPeople();
            Assert.IsTrue(lst.Count == 200);

            lst = m.GetPeople(5);
            Assert.IsTrue(lst.Count == 5);

            Assert.IsTrue(lst[0].PersonId == 1);
            Assert.IsTrue(lst[0].Name == "Florence Thornton");

        }

        [TestMethod]
        public void TestJustGetPeople()
        {

            var lst = MCronberg.PersonRepositoryStatic.JustGetPeople();
            Assert.IsTrue(lst.Count == 25);

            lst = MCronberg.PersonRepositoryStatic.JustGetPeople(10);
            Assert.IsTrue(lst.Count == 10);

        }


        [TestMethod]
        public void TestGetPerson()
        {            
            var p = m.GetPerson(1);
            Assert.IsNotNull(p);
            Assert.IsTrue(p.PersonId == 1);
            Assert.IsTrue(p.Name == "Florence Thornton");

        }

        [TestMethod]        
        public void TestAddPerson()
        {            
            m.AddPerson(new Person() { PersonId = 1000, FirstName = "a", LastName = "b" });
            var lst = m.GetPeople();
            Assert.IsTrue(lst.Count == 201);
            m.DeletePerson(1000);
            Assert.IsTrue(lst.Count == 200);
        }

        [TestMethod]        
        public void TestDeletePerson()
        {
            var p = m.GetPerson(1);
            m.DeletePerson(1);
            var r = m.GetPeople();
            Assert.IsTrue(r.Count == 199);
            m.AddPerson(p);
            Assert.IsTrue(r.Count == 200);
        }

        [TestMethod]
        public void TestUpdatePerson()
        {
            var p = m.GetPerson(10);
            p.FirstName = "*";
            m.UpdatePerson(p);
            var person = m.GetPerson(10);
            Assert.IsTrue(person.FirstName == "*");
        }
    }
}
