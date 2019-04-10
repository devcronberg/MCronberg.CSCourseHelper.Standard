using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace MCronberg
{
    public class PersonRepositoryFile : IPersonRepository
    {
        private readonly string file;
        public PersonRepositoryFile(string file)
        {
            this.file = file;
        }

        


        public void AddPerson(Person p)
        {
            List<Person> lst = GetPeople();
            lst.Add(p);
            Save(lst);
        }

        public void DeletePerson(int id)
        {
            try
            {
                List<Person> lst = Load();
                Person person = lst.Where(i => i.PersonId == id).First();
                lst.Remove(person);
                Save(lst);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting " + id, ex);
            }
        }

        public void Dispose()
        {

        }

        private List<Person> Load()
        {

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
                using (StreamReader xml = new StreamReader(file))
                {
                    return (List<Person>)ser.Deserialize(xml);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error loading people from " + file, ex);
            }
        }

        private void Save(List<Person> lst)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
                using (TextWriter writer = new StreamWriter(file))
                {
                    ser.Serialize(writer, lst);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing people", ex);
            }
        }

        public static List<Person> JustGetPeople(int count = 25, string path = "")
        {
            PersonRepositoryFile m = new PersonRepositoryFile(path);
            return m.GetPeople(count);
        }

        public static void SaveToFile(List<Person> lst, string path)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Person>));
                using (TextWriter writer = new StreamWriter(path))
                {
                    ser.Serialize(writer, lst);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error writing people", ex);
            }
        }

        public List<Person> GetPeople()
        {
            if (!System.IO.File.Exists(file))
            {
                return new List<Person>();
            }

            return Load();
        }


        public List<Person> GetPeople(int count)
        {
            return Load().Take(count).ToList();
        }

        public Person GetPerson(int id)
        {
            try
            {
                return GetPeople().Where(i => i.PersonId == id).First();
            }
            catch (Exception ex)
            {
                throw new Exception("Error finding " + id, ex);
            }
        }

        public void UpdatePerson(Person p)
        {
            try
            {
                List<Person> lst = Load();
                Person person = lst.Where(i => i.PersonId == p.PersonId).First();
                person.DateOfBirth = p.DateOfBirth;
                person.FirstName = p.FirstName;
                person.Gender = p.Gender;
                person.Height = p.Height;
                person.IsHealthy = p.IsHealthy;
                person.LastName = p.LastName;
                person.PersonId = p.PersonId;
                Save(lst);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating " + p.PersonId, ex);
            }
        }

        public static string CreateFileWithMockData(string path = null)
        {
            if (path == null)
            {
                path = System.IO.Path.GetTempFileName();
            }

            var l = PersonRepositoryMock.JustGetPeople(200);
            PersonRepositoryFile.SaveToFile(l, path);
            return path;
        }

        public static string CreateFileWithRandomData(string path = null)
        {
            if (path == null)
            {
                path = System.IO.Path.GetTempFileName();
            }

            var l = PersonRepositoryStatic.JustGetPeople(200);
            PersonRepositoryFile.SaveToFile(l, path);
            return path;
        }
    }
}