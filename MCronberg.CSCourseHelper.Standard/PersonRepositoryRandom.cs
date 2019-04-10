﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MCronberg
{
    public class PersonRepositoryRandom : IPersonRepository
    {
        private static Random rnd = new Random();
        private static List<Person> people;

        private static List<Person> GetRandomPeople()
        {
            List<Person> lst = GetFemales().Union(GetMales()).OrderBy(_ => Guid.NewGuid().ToString()).ToList();
            int id = 1;
            foreach (Person p in lst)
            {
                p.PersonId = id++;
                p.DateOfBirth = DateTime.Now.Date.AddDays(-rnd.Next(1, 36000));
                p.Height = rnd.Next(150, 205);
                p.IsHealthy = rnd.Next(0, 10) >= 7 ? true : false;
            }
            return lst;
        }

        private static List<Person> GetFemales()
        {
            // http://random-name-generator.info
            List<Person> lst = new List<Person>() { new Person() { FirstName = "Janice", LastName = "Wood", Gender = Gender.Female }, new Person() { FirstName = "Cecilia", LastName = "Perry", Gender = Gender.Female }, new Person() { FirstName = "Marguerite", LastName = "Watts", Gender = Gender.Female }, new Person() { FirstName = "Raquel", LastName = "Garrett", Gender = Gender.Female }, new Person() { FirstName = "Roberta", LastName = "Carr", Gender = Gender.Female }, new Person() { FirstName = "Agnes", LastName = "Coleman", Gender = Gender.Female }, new Person() { FirstName = "Misty", LastName = "Moreno", Gender = Gender.Female }, new Person() { FirstName = "Myrtle", LastName = "Russell", Gender = Gender.Female }, new Person() { FirstName = "Irma", LastName = "Morris", Gender = Gender.Female }, new Person() { FirstName = "Tiffany", LastName = "Alexander", Gender = Gender.Female }, new Person() { FirstName = "Sophia", LastName = "Fleming", Gender = Gender.Female }, new Person() { FirstName = "Isabel", LastName = "Mcdonald", Gender = Gender.Female }, new Person() { FirstName = "Ebony", LastName = "Mclaughlin", Gender = Gender.Female }, new Person() { FirstName = "Lela", LastName = "Garza", Gender = Gender.Female }, new Person() { FirstName = "Hope", LastName = "Medina", Gender = Gender.Female }, new Person() { FirstName = "Mattie", LastName = "Hall", Gender = Gender.Female }, new Person() { FirstName = "Denise", LastName = "Griffin", Gender = Gender.Female }, new Person() { FirstName = "Pamela", LastName = "Harvey", Gender = Gender.Female }, new Person() { FirstName = "Essie", LastName = "Cortez", Gender = Gender.Female }, new Person() { FirstName = "Freda", LastName = "Colon", Gender = Gender.Female }, new Person() { FirstName = "Sabrina", LastName = "West", Gender = Gender.Female }, new Person() { FirstName = "Jaime", LastName = "Bennett", Gender = Gender.Female }, new Person() { FirstName = "Kellie", LastName = "Hammond", Gender = Gender.Female }, new Person() { FirstName = "Kerry", LastName = "Ferguson", Gender = Gender.Female }, new Person() { FirstName = "Chelsea", LastName = "Walsh", Gender = Gender.Female }, new Person() { FirstName = "Kay", LastName = "Fernandez", Gender = Gender.Female }, new Person() { FirstName = "Melody", LastName = "Ingram", Gender = Gender.Female }, new Person() { FirstName = "Lynn", LastName = "Christensen", Gender = Gender.Female }, new Person() { FirstName = "Judy", LastName = "Frank", Gender = Gender.Female }, new Person() { FirstName = "Debra", LastName = "Snyder", Gender = Gender.Female }, new Person() { FirstName = "Vivian", LastName = "Thomas", Gender = Gender.Female }, new Person() { FirstName = "Hannah", LastName = "Wilson", Gender = Gender.Female }, new Person() { FirstName = "Verna", LastName = "Sullivan", Gender = Gender.Female }, new Person() { FirstName = "Jodi", LastName = "Obrien", Gender = Gender.Female }, new Person() { FirstName = "Candice", LastName = "Chandler", Gender = Gender.Female }, new Person() { FirstName = "Leah", LastName = "Wade", Gender = Gender.Female }, new Person() { FirstName = "Katrina", LastName = "Hansen", Gender = Gender.Female }, new Person() { FirstName = "Lee", LastName = "Meyer", Gender = Gender.Female }, new Person() { FirstName = "Alison", LastName = "Vasquez", Gender = Gender.Female }, new Person() { FirstName = "Dianne", LastName = "Gray", Gender = Gender.Female }, new Person() { FirstName = "Irene", LastName = "Mills", Gender = Gender.Female }, new Person() { FirstName = "Jenny", LastName = "Patton", Gender = Gender.Female }, new Person() { FirstName = "Carolyn", LastName = "Lindsey", Gender = Gender.Female }, new Person() { FirstName = "Jessie", LastName = "Lopez", Gender = Gender.Female }, new Person() { FirstName = "Florence", LastName = "Thornton", Gender = Gender.Female }, new Person() { FirstName = "Alice", LastName = "Little", Gender = Gender.Female }, new Person() { FirstName = "Ida", LastName = "Stevenson", Gender = Gender.Female }, new Person() { FirstName = "April", LastName = "Patterson", Gender = Gender.Female }, new Person() { FirstName = "Marsha", LastName = "Ward", Gender = Gender.Female }, new Person() { FirstName = "Charlotte", LastName = "Mitchell", Gender = Gender.Female }, new Person() { FirstName = "Cheryl", LastName = "Ramos", Gender = Gender.Female }, new Person() { FirstName = "Betsy", LastName = "Vargas", Gender = Gender.Female }, new Person() { FirstName = "Thelma", LastName = "Crawford", Gender = Gender.Female }, new Person() { FirstName = "Fannie", LastName = "Gibson", Gender = Gender.Female }, new Person() { FirstName = "Jane", LastName = "Herrera", Gender = Gender.Female }, new Person() { FirstName = "Margaret", LastName = "Tyler", Gender = Gender.Female }, new Person() { FirstName = "Kate", LastName = "Newman", Gender = Gender.Female }, new Person() { FirstName = "Angela", LastName = "Porter", Gender = Gender.Female }, new Person() { FirstName = "Delia", LastName = "Cross", Gender = Gender.Female }, new Person() { FirstName = "Lucille", LastName = "Wise", Gender = Gender.Female }, new Person() { FirstName = "Jeannette", LastName = "Lambert", Gender = Gender.Female }, new Person() { FirstName = "Patti", LastName = "Diaz", Gender = Gender.Female }, new Person() { FirstName = "Colleen", LastName = "Hudson", Gender = Gender.Female }, new Person() { FirstName = "Donna", LastName = "Cohen", Gender = Gender.Female }, new Person() { FirstName = "Dora", LastName = "Barton", Gender = Gender.Female }, new Person() { FirstName = "Christine", LastName = "Buchanan", Gender = Gender.Female }, new Person() { FirstName = "Tina", LastName = "Underwood", Gender = Gender.Female }, new Person() { FirstName = "Melanie", LastName = "Erickson", Gender = Gender.Female }, new Person() { FirstName = "Patty", LastName = "Simmons", Gender = Gender.Female }, new Person() { FirstName = "Jeanette", LastName = "Murphy", Gender = Gender.Female }, new Person() { FirstName = "Renee", LastName = "Warren", Gender = Gender.Female }, new Person() { FirstName = "Susan", LastName = "Brady", Gender = Gender.Female }, new Person() { FirstName = "Monica", LastName = "Moody", Gender = Gender.Female }, new Person() { FirstName = "Tami", LastName = "Sims", Gender = Gender.Female }, new Person() { FirstName = "Celia", LastName = "Jennings", Gender = Gender.Female }, new Person() { FirstName = "Robin", LastName = "Watson", Gender = Gender.Female }, new Person() { FirstName = "Vickie", LastName = "Pratt", Gender = Gender.Female }, new Person() { FirstName = "Eileen", LastName = "Zimmerman", Gender = Gender.Female }, new Person() { FirstName = "Maggie", LastName = "Baker", Gender = Gender.Female }, new Person() { FirstName = "Geraldine", LastName = "Flowers", Gender = Gender.Female }, new Person() { FirstName = "Michelle", LastName = "Conner", Gender = Gender.Female }, new Person() { FirstName = "Maryann", LastName = "Lowe", Gender = Gender.Female }, new Person() { FirstName = "Jill", LastName = "Pittman", Gender = Gender.Female }, new Person() { FirstName = "Ruth", LastName = "Nichols", Gender = Gender.Female }, new Person() { FirstName = "Mercedes", LastName = "Newton", Gender = Gender.Female }, new Person() { FirstName = "Virginia", LastName = "Duncan", Gender = Gender.Female }, new Person() { FirstName = "Stacy", LastName = "Sparks", Gender = Gender.Female }, new Person() { FirstName = "Carla", LastName = "Goodman", Gender = Gender.Female }, new Person() { FirstName = "Elsie", LastName = "Ortega", Gender = Gender.Female }, new Person() { FirstName = "Rosalie", LastName = "Mathis", Gender = Gender.Female }, new Person() { FirstName = "Tracey", LastName = "Gomez", Gender = Gender.Female }, new Person() { FirstName = "Rebecca", LastName = "Aguilar", Gender = Gender.Female }, new Person() { FirstName = "Maria", LastName = "Brooks", Gender = Gender.Female }, new Person() { FirstName = "Gina", LastName = "Vega", Gender = Gender.Female }, new Person() { FirstName = "Mary", LastName = "Daniels", Gender = Gender.Female }, new Person() { FirstName = "Tracy", LastName = "James", Gender = Gender.Female }, new Person() { FirstName = "Dorothy", LastName = "Saunders", Gender = Gender.Female }, new Person() { FirstName = "Cristina", LastName = "Foster", Gender = Gender.Female }, new Person() { FirstName = "Marilyn", LastName = "Wallace", Gender = Gender.Female }, new Person() { FirstName = "Lydia", LastName = "Wells", Gender = Gender.Female } };
            return lst;
        }

        private static List<Person> GetMales()
        {
            // http://random-name-generator.info
            List<Person> lst = new List<Person>() { new Person() { FirstName = "Garrett", LastName = "Page", Gender = Gender.Male }, new Person() { FirstName = "Raymond", LastName = "Wilkins", Gender = Gender.Male }, new Person() { FirstName = "Ray", LastName = "Obrien", Gender = Gender.Male }, new Person() { FirstName = "Wallace", LastName = "Arnold", Gender = Gender.Male }, new Person() { FirstName = "Lamar", LastName = "Bush", Gender = Gender.Male }, new Person() { FirstName = "Roderick", LastName = "Garza", Gender = Gender.Male }, new Person() { FirstName = "Malcolm", LastName = "Ryan", Gender = Gender.Male }, new Person() { FirstName = "Daryl", LastName = "Glover", Gender = Gender.Male }, new Person() { FirstName = "Karl", LastName = "Hodges", Gender = Gender.Male }, new Person() { FirstName = "Victor", LastName = "Webb", Gender = Gender.Male }, new Person() { FirstName = "Dewey", LastName = "Logan", Gender = Gender.Male }, new Person() { FirstName = "Kerry", LastName = "Stevenson", Gender = Gender.Male }, new Person() { FirstName = "Emanuel", LastName = "Lamb", Gender = Gender.Male }, new Person() { FirstName = "Pedro", LastName = "Marshall", Gender = Gender.Male }, new Person() { FirstName = "Hector", LastName = "Tate", Gender = Gender.Male }, new Person() { FirstName = "Terry", LastName = "Simpson", Gender = Gender.Male }, new Person() { FirstName = "Marty", LastName = "Norton", Gender = Gender.Male }, new Person() { FirstName = "Julio", LastName = "Stokes", Gender = Gender.Male }, new Person() { FirstName = "John", LastName = "May", Gender = Gender.Male }, new Person() { FirstName = "Rene", LastName = "Patrick", Gender = Gender.Male }, new Person() { FirstName = "Jackie", LastName = "Huff", Gender = Gender.Male }, new Person() { FirstName = "Salvador", LastName = "Mclaughlin", Gender = Gender.Male }, new Person() { FirstName = "Ed", LastName = "Steele", Gender = Gender.Male }, new Person() { FirstName = "Philip", LastName = "Medina", Gender = Gender.Male }, new Person() { FirstName = "Marlon", LastName = "Goodwin", Gender = Gender.Male }, new Person() { FirstName = "Clayton", LastName = "Jenkins", Gender = Gender.Male }, new Person() { FirstName = "Alexander", LastName = "Buchanan", Gender = Gender.Male }, new Person() { FirstName = "Frank", LastName = "Franklin", Gender = Gender.Male }, new Person() { FirstName = "Wesley", LastName = "Gomez", Gender = Gender.Male }, new Person() { FirstName = "Leroy", LastName = "Wong", Gender = Gender.Male }, new Person() { FirstName = "Taylor", LastName = "Brewer", Gender = Gender.Male }, new Person() { FirstName = "Abraham", LastName = "Evans", Gender = Gender.Male }, new Person() { FirstName = "Amos", LastName = "Neal", Gender = Gender.Male }, new Person() { FirstName = "Steve", LastName = "Cain", Gender = Gender.Male }, new Person() { FirstName = "Willard", LastName = "Adkins", Gender = Gender.Male }, new Person() { FirstName = "Randolph", LastName = "Matthews", Gender = Gender.Male }, new Person() { FirstName = "Rufus", LastName = "Lane", Gender = Gender.Male }, new Person() { FirstName = "Brent", LastName = "Douglas", Gender = Gender.Male }, new Person() { FirstName = "Darren", LastName = "Fuller", Gender = Gender.Male }, new Person() { FirstName = "Boyd", LastName = "Young", Gender = Gender.Male }, new Person() { FirstName = "Otis", LastName = "Thompson", Gender = Gender.Male }, new Person() { FirstName = "Brandon", LastName = "Bell", Gender = Gender.Male }, new Person() { FirstName = "Mathew", LastName = "Rhodes", Gender = Gender.Male }, new Person() { FirstName = "Jordan", LastName = "Perry", Gender = Gender.Male }, new Person() { FirstName = "Daniel", LastName = "Becker", Gender = Gender.Male }, new Person() { FirstName = "Richard", LastName = "Foster", Gender = Gender.Male }, new Person() { FirstName = "Bert", LastName = "Ramirez", Gender = Gender.Male }, new Person() { FirstName = "Ken", LastName = "Jacobs", Gender = Gender.Male }, new Person() { FirstName = "Noah", LastName = "Vargas", Gender = Gender.Male }, new Person() { FirstName = "Jesus", LastName = "Stevens", Gender = Gender.Male }, new Person() { FirstName = "Wilson", LastName = "Lawrence", Gender = Gender.Male }, new Person() { FirstName = "Tommy", LastName = "Swanson", Gender = Gender.Male }, new Person() { FirstName = "Paul", LastName = "Walters", Gender = Gender.Male }, new Person() { FirstName = "Howard", LastName = "Peterson", Gender = Gender.Male }, new Person() { FirstName = "Conrad", LastName = "Burgess", Gender = Gender.Male }, new Person() { FirstName = "Hubert", LastName = "Davis", Gender = Gender.Male }, new Person() { FirstName = "William", LastName = "Myers", Gender = Gender.Male }, new Person() { FirstName = "Edward", LastName = "Frazier", Gender = Gender.Male }, new Person() { FirstName = "Julius", LastName = "Owens", Gender = Gender.Male }, new Person() { FirstName = "Lyle", LastName = "Reeves", Gender = Gender.Male }, new Person() { FirstName = "Duane", LastName = "Boone", Gender = Gender.Male }, new Person() { FirstName = "Delbert", LastName = "Harper", Gender = Gender.Male }, new Person() { FirstName = "Alonzo", LastName = "Perkins", Gender = Gender.Male }, new Person() { FirstName = "Darrel", LastName = "Schneider", Gender = Gender.Male }, new Person() { FirstName = "Bryant", LastName = "Long", Gender = Gender.Male }, new Person() { FirstName = "Lewis", LastName = "Hubbard", Gender = Gender.Male }, new Person() { FirstName = "Alvin", LastName = "Clayton", Gender = Gender.Male }, new Person() { FirstName = "Josh", LastName = "Nash", Gender = Gender.Male }, new Person() { FirstName = "Reginald", LastName = "Summers", Gender = Gender.Male }, new Person() { FirstName = "Oscar", LastName = "Kim", Gender = Gender.Male }, new Person() { FirstName = "Grant", LastName = "Duncan", Gender = Gender.Male }, new Person() { FirstName = "Nicolas", LastName = "Lyons", Gender = Gender.Male }, new Person() { FirstName = "Dean", LastName = "Mann", Gender = Gender.Male }, new Person() { FirstName = "Felix", LastName = "Austin", Gender = Gender.Male }, new Person() { FirstName = "Andrew", LastName = "Figueroa", Gender = Gender.Male }, new Person() { FirstName = "Terrell", LastName = "Simon", Gender = Gender.Male }, new Person() { FirstName = "Mitchell", LastName = "Hogan", Gender = Gender.Male }, new Person() { FirstName = "Ron", LastName = "Harrison", Gender = Gender.Male }, new Person() { FirstName = "Vincent", LastName = "Bowers", Gender = Gender.Male }, new Person() { FirstName = "Herman", LastName = "Sanchez", Gender = Gender.Male }, new Person() { FirstName = "Virgil", LastName = "Gonzalez", Gender = Gender.Male }, new Person() { FirstName = "Fred", LastName = "Estrada", Gender = Gender.Male }, new Person() { FirstName = "Jimmy", LastName = "Love", Gender = Gender.Male }, new Person() { FirstName = "Francisco", LastName = "Mullins", Gender = Gender.Male }, new Person() { FirstName = "Adrian", LastName = "Moss", Gender = Gender.Male }, new Person() { FirstName = "Pablo", LastName = "Potter", Gender = Gender.Male }, new Person() { FirstName = "Clinton", LastName = "Sandoval", Gender = Gender.Male }, new Person() { FirstName = "Jessie", LastName = "Willis", Gender = Gender.Male }, new Person() { FirstName = "Alfredo", LastName = "Mcguire", Gender = Gender.Male }, new Person() { FirstName = "Corey", LastName = "Cunningham", Gender = Gender.Male }, new Person() { FirstName = "Jean", LastName = "Graham", Gender = Gender.Male }, new Person() { FirstName = "Bernard", LastName = "Barrett", Gender = Gender.Male }, new Person() { FirstName = "Joshua", LastName = "Cooper", Gender = Gender.Male }, new Person() { FirstName = "Ruben", LastName = "Rivera", Gender = Gender.Male }, new Person() { FirstName = "Alfred", LastName = "Hall", Gender = Gender.Male }, new Person() { FirstName = "Jose", LastName = "Pena", Gender = Gender.Male }, new Person() { FirstName = "Allan", LastName = "Brady", Gender = Gender.Male }, new Person() { FirstName = "Earnest", LastName = "Ross", Gender = Gender.Male }, new Person() { FirstName = "Gabriel", LastName = "Burke", Gender = Gender.Male }, new Person() { FirstName = "Ervin", LastName = "Hill", Gender = Gender.Male } };
            return lst;
        }


        static PersonRepositoryRandom()
        {
            people = GetRandomPeople();
        }


        public static List<Person> JustGetPeople(int count = 25)
        {
            return people.OrderBy(i => i.PersonId).Take(count).ToList();
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public List<Person> GetPeople(int count)
        {
            return people.Take(count).ToList();
        }

        public Person GetPerson(int id)
        {
            return GetPeople().Where(i => i.PersonId == id).FirstOrDefault();
        }

        public void AddPerson(Person p)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(Person p)
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
    }
}