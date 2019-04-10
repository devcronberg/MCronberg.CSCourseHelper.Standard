using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCronberg
{
    public class PersonRepositoryStatic : IPersonRepository
    {

        static List<Person> people;

        static PersonRepositoryStatic() {
            var lst = new List<Person>();
            Person p;
            p = new Person { PersonId = 1, FirstName = "Florence", LastName = "Thornton", Height = 191, DateOfBirth = new DateTime(2003, 05, 10), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 2, FirstName = "Colleen", LastName = "Hudson", Height = 161, DateOfBirth = new DateTime(2013, 06, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 3, FirstName = "Raquel", LastName = "Garrett", Height = 185, DateOfBirth = new DateTime(1951, 11, 18), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 4, FirstName = "Earnest", LastName = "Ross", Height = 203, DateOfBirth = new DateTime(1983, 06, 23), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 5, FirstName = "Jackie", LastName = "Huff", Height = 168, DateOfBirth = new DateTime(1960, 12, 14), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 6, FirstName = "Kerry", LastName = "Ferguson", Height = 194, DateOfBirth = new DateTime(2005, 10, 10), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 7, FirstName = "Lyle", LastName = "Reeves", Height = 183, DateOfBirth = new DateTime(1963, 03, 05), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 8, FirstName = "Richard", LastName = "Foster", Height = 164, DateOfBirth = new DateTime(1966, 03, 25), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 9, FirstName = "Jaime", LastName = "Bennett", Height = 185, DateOfBirth = new DateTime(1937, 09, 28), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 10, FirstName = "Julio", LastName = "Stokes", Height = 153, DateOfBirth = new DateTime(1935, 07, 28), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 11, FirstName = "Jodi", LastName = "Obrien", Height = 185, DateOfBirth = new DateTime(2017, 02, 26), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 12, FirstName = "Ruth", LastName = "Nichols", Height = 153, DateOfBirth = new DateTime(1983, 11, 02), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 13, FirstName = "Tina", LastName = "Underwood", Height = 199, DateOfBirth = new DateTime(1949, 11, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 14, FirstName = "Margaret", LastName = "Tyler", Height = 192, DateOfBirth = new DateTime(1938, 02, 22), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 15, FirstName = "Wesley", LastName = "Gomez", Height = 154, DateOfBirth = new DateTime(2004, 07, 16), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 16, FirstName = "Roberta", LastName = "Carr", Height = 181, DateOfBirth = new DateTime(1926, 06, 05), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 17, FirstName = "Amos", LastName = "Neal", Height = 150, DateOfBirth = new DateTime(1929, 08, 30), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 18, FirstName = "Pedro", LastName = "Marshall", Height = 157, DateOfBirth = new DateTime(2002, 07, 19), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 19, FirstName = "Oscar", LastName = "Kim", Height = 184, DateOfBirth = new DateTime(1990, 05, 23), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 20, FirstName = "Essie", LastName = "Cortez", Height = 162, DateOfBirth = new DateTime(2006, 09, 22), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 21, FirstName = "Virginia", LastName = "Duncan", Height = 195, DateOfBirth = new DateTime(1967, 04, 08), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 22, FirstName = "Taylor", LastName = "Brewer", Height = 168, DateOfBirth = new DateTime(2014, 03, 13), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 23, FirstName = "Abraham", LastName = "Evans", Height = 162, DateOfBirth = new DateTime(1943, 03, 31), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 24, FirstName = "April", LastName = "Patterson", Height = 173, DateOfBirth = new DateTime(1938, 05, 17), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 25, FirstName = "Sabrina", LastName = "West", Height = 191, DateOfBirth = new DateTime(1954, 03, 02), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 26, FirstName = "Candice", LastName = "Chandler", Height = 171, DateOfBirth = new DateTime(1968, 03, 17), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 27, FirstName = "Jeannette", LastName = "Lambert", Height = 198, DateOfBirth = new DateTime(1999, 09, 15), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 28, FirstName = "Julius", LastName = "Owens", Height = 201, DateOfBirth = new DateTime(1998, 06, 08), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 29, FirstName = "Delia", LastName = "Cross", Height = 196, DateOfBirth = new DateTime(2007, 07, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 30, FirstName = "Dianne", LastName = "Gray", Height = 153, DateOfBirth = new DateTime(1993, 11, 19), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 31, FirstName = "Jill", LastName = "Pittman", Height = 181, DateOfBirth = new DateTime(1968, 01, 06), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 32, FirstName = "Maggie", LastName = "Baker", Height = 166, DateOfBirth = new DateTime(1933, 02, 27), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 33, FirstName = "Tami", LastName = "Sims", Height = 155, DateOfBirth = new DateTime(1933, 12, 12), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 34, FirstName = "Rebecca", LastName = "Aguilar", Height = 159, DateOfBirth = new DateTime(1937, 12, 04), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 35, FirstName = "Raymond", LastName = "Wilkins", Height = 154, DateOfBirth = new DateTime(2007, 04, 07), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 36, FirstName = "Lamar", LastName = "Bush", Height = 178, DateOfBirth = new DateTime(1985, 01, 12), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 37, FirstName = "Pablo", LastName = "Potter", Height = 192, DateOfBirth = new DateTime(1939, 04, 06), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 38, FirstName = "Alison", LastName = "Vasquez", Height = 201, DateOfBirth = new DateTime(1989, 08, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 39, FirstName = "Nicolas", LastName = "Lyons", Height = 167, DateOfBirth = new DateTime(1969, 08, 10), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 40, FirstName = "Ruben", LastName = "Rivera", Height = 201, DateOfBirth = new DateTime(1969, 09, 05), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 41, FirstName = "Judy", LastName = "Frank", Height = 178, DateOfBirth = new DateTime(1939, 04, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 42, FirstName = "Kerry", LastName = "Stevenson", Height = 166, DateOfBirth = new DateTime(1936, 10, 07), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 43, FirstName = "Felix", LastName = "Austin", Height = 193, DateOfBirth = new DateTime(1993, 12, 18), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 44, FirstName = "Reginald", LastName = "Summers", Height = 185, DateOfBirth = new DateTime(1929, 09, 26), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 45, FirstName = "Edward", LastName = "Frazier", Height = 170, DateOfBirth = new DateTime(1974, 10, 11), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 46, FirstName = "Dewey", LastName = "Logan", Height = 154, DateOfBirth = new DateTime(1946, 06, 21), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 47, FirstName = "Janice", LastName = "Wood", Height = 192, DateOfBirth = new DateTime(1970, 02, 01), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 48, FirstName = "Leroy", LastName = "Wong", Height = 174, DateOfBirth = new DateTime(2007, 01, 23), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 49, FirstName = "Dorothy", LastName = "Saunders", Height = 162, DateOfBirth = new DateTime(1999, 07, 15), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 50, FirstName = "Wilson", LastName = "Lawrence", Height = 170, DateOfBirth = new DateTime(1987, 12, 28), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 51, FirstName = "Ed", LastName = "Steele", Height = 169, DateOfBirth = new DateTime(2015, 01, 26), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 52, FirstName = "Steve", LastName = "Cain", Height = 150, DateOfBirth = new DateTime(1995, 02, 15), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 53, FirstName = "Wallace", LastName = "Arnold", Height = 165, DateOfBirth = new DateTime(2002, 09, 03), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 54, FirstName = "Rene", LastName = "Patrick", Height = 154, DateOfBirth = new DateTime(1949, 01, 05), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 55, FirstName = "Bryant", LastName = "Long", Height = 199, DateOfBirth = new DateTime(1926, 12, 08), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 56, FirstName = "Jeanette", LastName = "Murphy", Height = 196, DateOfBirth = new DateTime(1926, 03, 31), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 57, FirstName = "Irene", LastName = "Mills", Height = 192, DateOfBirth = new DateTime(1956, 12, 18), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 58, FirstName = "William", LastName = "Myers", Height = 150, DateOfBirth = new DateTime(2015, 01, 20), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 59, FirstName = "Herman", LastName = "Sanchez", Height = 187, DateOfBirth = new DateTime(2004, 10, 02), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 60, FirstName = "Jane", LastName = "Herrera", Height = 185, DateOfBirth = new DateTime(1933, 02, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 61, FirstName = "Ray", LastName = "Obrien", Height = 201, DateOfBirth = new DateTime(1998, 11, 04), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 62, FirstName = "Kate", LastName = "Newman", Height = 197, DateOfBirth = new DateTime(1972, 10, 26), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 63, FirstName = "Mathew", LastName = "Rhodes", Height = 161, DateOfBirth = new DateTime(2006, 12, 01), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 64, FirstName = "Mattie", LastName = "Hall", Height = 181, DateOfBirth = new DateTime(2013, 07, 31), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 65, FirstName = "Delbert", LastName = "Harper", Height = 193, DateOfBirth = new DateTime(2012, 12, 17), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 66, FirstName = "Allan", LastName = "Brady", Height = 160, DateOfBirth = new DateTime(1958, 02, 14), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 67, FirstName = "Adrian", LastName = "Moss", Height = 164, DateOfBirth = new DateTime(2002, 08, 13), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 68, FirstName = "Angela", LastName = "Porter", Height = 187, DateOfBirth = new DateTime(2010, 02, 19), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 69, FirstName = "Alfredo", LastName = "Mcguire", Height = 204, DateOfBirth = new DateTime(1945, 02, 04), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 70, FirstName = "Charlotte", LastName = "Mitchell", Height = 155, DateOfBirth = new DateTime(2018, 11, 02), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 71, FirstName = "Dora", LastName = "Barton", Height = 166, DateOfBirth = new DateTime(1961, 03, 28), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 72, FirstName = "Boyd", LastName = "Young", Height = 177, DateOfBirth = new DateTime(1949, 08, 30), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 73, FirstName = "Jesus", LastName = "Stevens", Height = 175, DateOfBirth = new DateTime(1989, 03, 12), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 74, FirstName = "Ken", LastName = "Jacobs", Height = 195, DateOfBirth = new DateTime(1937, 03, 13), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 75, FirstName = "Katrina", LastName = "Hansen", Height = 181, DateOfBirth = new DateTime(1999, 12, 10), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 76, FirstName = "Salvador", LastName = "Mclaughlin", Height = 203, DateOfBirth = new DateTime(1977, 09, 12), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 77, FirstName = "Elsie", LastName = "Ortega", Height = 178, DateOfBirth = new DateTime(1971, 12, 17), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 78, FirstName = "Garrett", LastName = "Page", Height = 188, DateOfBirth = new DateTime(1967, 06, 20), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 79, FirstName = "Hannah", LastName = "Wilson", Height = 156, DateOfBirth = new DateTime(1949, 02, 28), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 80, FirstName = "Marty", LastName = "Norton", Height = 189, DateOfBirth = new DateTime(1939, 03, 10), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 81, FirstName = "Maria", LastName = "Brooks", Height = 156, DateOfBirth = new DateTime(1927, 06, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 82, FirstName = "Melanie", LastName = "Erickson", Height = 175, DateOfBirth = new DateTime(2015, 12, 21), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 83, FirstName = "Debra", LastName = "Snyder", Height = 169, DateOfBirth = new DateTime(2003, 10, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 84, FirstName = "Alexander", LastName = "Buchanan", Height = 167, DateOfBirth = new DateTime(1967, 01, 22), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 85, FirstName = "Freda", LastName = "Colon", Height = 168, DateOfBirth = new DateTime(1969, 07, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 86, FirstName = "Misty", LastName = "Moreno", Height = 199, DateOfBirth = new DateTime(1947, 08, 05), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 87, FirstName = "Corey", LastName = "Cunningham", Height = 168, DateOfBirth = new DateTime(1978, 11, 28), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 88, FirstName = "Maryann", LastName = "Lowe", Height = 178, DateOfBirth = new DateTime(2005, 06, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 89, FirstName = "Jimmy", LastName = "Love", Height = 153, DateOfBirth = new DateTime(1937, 12, 06), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 90, FirstName = "Conrad", LastName = "Burgess", Height = 204, DateOfBirth = new DateTime(1992, 11, 28), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 91, FirstName = "Randolph", LastName = "Matthews", Height = 177, DateOfBirth = new DateTime(1930, 11, 10), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 92, FirstName = "Hubert", LastName = "Davis", Height = 199, DateOfBirth = new DateTime(2002, 05, 10), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 93, FirstName = "Brandon", LastName = "Bell", Height = 158, DateOfBirth = new DateTime(1966, 08, 19), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 94, FirstName = "Terrell", LastName = "Simon", Height = 164, DateOfBirth = new DateTime(1928, 09, 07), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 95, FirstName = "Clayton", LastName = "Jenkins", Height = 202, DateOfBirth = new DateTime(1926, 11, 20), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 96, FirstName = "Bert", LastName = "Ramirez", Height = 151, DateOfBirth = new DateTime(1942, 06, 22), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 97, FirstName = "Gabriel", LastName = "Burke", Height = 204, DateOfBirth = new DateTime(1926, 05, 17), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 98, FirstName = "Jessie", LastName = "Willis", Height = 172, DateOfBirth = new DateTime(2005, 02, 20), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 99, FirstName = "Ron", LastName = "Harrison", Height = 193, DateOfBirth = new DateTime(1935, 12, 30), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 100, FirstName = "Joshua", LastName = "Cooper", Height = 161, DateOfBirth = new DateTime(1966, 04, 02), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 101, FirstName = "Vickie", LastName = "Pratt", Height = 198, DateOfBirth = new DateTime(1951, 08, 01), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 102, FirstName = "Darrel", LastName = "Schneider", Height = 184, DateOfBirth = new DateTime(1931, 08, 04), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 103, FirstName = "Karl", LastName = "Hodges", Height = 168, DateOfBirth = new DateTime(1923, 03, 17), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 104, FirstName = "Clinton", LastName = "Sandoval", Height = 160, DateOfBirth = new DateTime(1946, 04, 20), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 105, FirstName = "Marlon", LastName = "Goodwin", Height = 176, DateOfBirth = new DateTime(2018, 10, 01), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 106, FirstName = "Christine", LastName = "Buchanan", Height = 161, DateOfBirth = new DateTime(1979, 11, 05), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 107, FirstName = "Pamela", LastName = "Harvey", Height = 152, DateOfBirth = new DateTime(1983, 11, 15), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 108, FirstName = "Darren", LastName = "Fuller", Height = 167, DateOfBirth = new DateTime(1997, 07, 24), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 109, FirstName = "Mercedes", LastName = "Newton", Height = 191, DateOfBirth = new DateTime(2002, 03, 24), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 110, FirstName = "Andrew", LastName = "Figueroa", Height = 167, DateOfBirth = new DateTime(1983, 11, 23), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 111, FirstName = "Fannie", LastName = "Gibson", Height = 204, DateOfBirth = new DateTime(2009, 04, 27), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 112, FirstName = "John", LastName = "May", Height = 162, DateOfBirth = new DateTime(1950, 04, 20), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 113, FirstName = "Rosalie", LastName = "Mathis", Height = 152, DateOfBirth = new DateTime(1993, 10, 28), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 114, FirstName = "Patti", LastName = "Diaz", Height = 194, DateOfBirth = new DateTime(1980, 12, 04), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 115, FirstName = "Alfred", LastName = "Hall", Height = 161, DateOfBirth = new DateTime(1927, 03, 24), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 116, FirstName = "Duane", LastName = "Boone", Height = 157, DateOfBirth = new DateTime(1971, 07, 21), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 117, FirstName = "Chelsea", LastName = "Walsh", Height = 174, DateOfBirth = new DateTime(1987, 07, 18), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 118, FirstName = "Patty", LastName = "Simmons", Height = 159, DateOfBirth = new DateTime(2017, 01, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 119, FirstName = "Stacy", LastName = "Sparks", Height = 175, DateOfBirth = new DateTime(1983, 06, 19), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 120, FirstName = "Rufus", LastName = "Lane", Height = 189, DateOfBirth = new DateTime(1984, 07, 30), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 121, FirstName = "Lucille", LastName = "Wise", Height = 183, DateOfBirth = new DateTime(1947, 01, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 122, FirstName = "Lewis", LastName = "Hubbard", Height = 185, DateOfBirth = new DateTime(1987, 04, 06), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 123, FirstName = "Verna", LastName = "Sullivan", Height = 166, DateOfBirth = new DateTime(1942, 06, 14), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 124, FirstName = "Alvin", LastName = "Clayton", Height = 157, DateOfBirth = new DateTime(1951, 03, 14), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 125, FirstName = "Bernard", LastName = "Barrett", Height = 203, DateOfBirth = new DateTime(1993, 12, 28), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 126, FirstName = "Cecilia", LastName = "Perry", Height = 165, DateOfBirth = new DateTime(1984, 04, 18), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 127, FirstName = "Gina", LastName = "Vega", Height = 187, DateOfBirth = new DateTime(1997, 08, 05), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 128, FirstName = "Otis", LastName = "Thompson", Height = 152, DateOfBirth = new DateTime(2001, 10, 27), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 129, FirstName = "Daniel", LastName = "Becker", Height = 154, DateOfBirth = new DateTime(1967, 10, 19), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 130, FirstName = "Mitchell", LastName = "Hogan", Height = 168, DateOfBirth = new DateTime(1941, 03, 06), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 131, FirstName = "Malcolm", LastName = "Ryan", Height = 199, DateOfBirth = new DateTime(1939, 05, 14), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 132, FirstName = "Josh", LastName = "Nash", Height = 186, DateOfBirth = new DateTime(1976, 01, 18), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 133, FirstName = "Alice", LastName = "Little", Height = 183, DateOfBirth = new DateTime(1952, 02, 23), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 134, FirstName = "Melody", LastName = "Ingram", Height = 188, DateOfBirth = new DateTime(1960, 09, 26), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 135, FirstName = "Cheryl", LastName = "Ramos", Height = 184, DateOfBirth = new DateTime(1954, 10, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 136, FirstName = "Isabel", LastName = "Mcdonald", Height = 192, DateOfBirth = new DateTime(1976, 08, 20), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 137, FirstName = "Kellie", LastName = "Hammond", Height = 150, DateOfBirth = new DateTime(1928, 07, 17), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 138, FirstName = "Lela", LastName = "Garza", Height = 157, DateOfBirth = new DateTime(1975, 09, 21), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 139, FirstName = "Thelma", LastName = "Crawford", Height = 180, DateOfBirth = new DateTime(1993, 04, 21), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 140, FirstName = "Donna", LastName = "Cohen", Height = 194, DateOfBirth = new DateTime(2006, 12, 24), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 141, FirstName = "Agnes", LastName = "Coleman", Height = 204, DateOfBirth = new DateTime(1981, 11, 08), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 142, FirstName = "Lynn", LastName = "Christensen", Height = 198, DateOfBirth = new DateTime(1970, 09, 30), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 143, FirstName = "Ida", LastName = "Stevenson", Height = 194, DateOfBirth = new DateTime(1938, 01, 08), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 144, FirstName = "Victor", LastName = "Webb", Height = 187, DateOfBirth = new DateTime(2014, 01, 26), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 145, FirstName = "Marguerite", LastName = "Watts", Height = 184, DateOfBirth = new DateTime(1964, 01, 31), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 146, FirstName = "Francisco", LastName = "Mullins", Height = 178, DateOfBirth = new DateTime(1942, 02, 07), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 147, FirstName = "Robin", LastName = "Watson", Height = 154, DateOfBirth = new DateTime(1962, 03, 26), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 148, FirstName = "Jean", LastName = "Graham", Height = 197, DateOfBirth = new DateTime(1959, 04, 11), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 149, FirstName = "Lee", LastName = "Meyer", Height = 170, DateOfBirth = new DateTime(1961, 07, 21), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 150, FirstName = "Jessie", LastName = "Lopez", Height = 159, DateOfBirth = new DateTime(1989, 05, 25), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 151, FirstName = "Mary", LastName = "Daniels", Height = 180, DateOfBirth = new DateTime(1959, 02, 21), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 152, FirstName = "Vincent", LastName = "Bowers", Height = 161, DateOfBirth = new DateTime(2019, 01, 31), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 153, FirstName = "Willard", LastName = "Adkins", Height = 158, DateOfBirth = new DateTime(1934, 02, 26), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 154, FirstName = "Tracey", LastName = "Gomez", Height = 183, DateOfBirth = new DateTime(2012, 08, 14), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 155, FirstName = "Alonzo", LastName = "Perkins", Height = 197, DateOfBirth = new DateTime(1931, 02, 04), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 156, FirstName = "Marilyn", LastName = "Wallace", Height = 198, DateOfBirth = new DateTime(1969, 09, 13), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 157, FirstName = "Irma", LastName = "Morris", Height = 176, DateOfBirth = new DateTime(2014, 12, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 158, FirstName = "Carolyn", LastName = "Lindsey", Height = 180, DateOfBirth = new DateTime(2002, 03, 24), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 159, FirstName = "Monica", LastName = "Moody", Height = 192, DateOfBirth = new DateTime(1994, 10, 16), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 160, FirstName = "Tiffany", LastName = "Alexander", Height = 199, DateOfBirth = new DateTime(1956, 02, 04), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 161, FirstName = "Brent", LastName = "Douglas", Height = 178, DateOfBirth = new DateTime(1973, 10, 17), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 162, FirstName = "Kay", LastName = "Fernandez", Height = 174, DateOfBirth = new DateTime(1998, 03, 14), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 163, FirstName = "Grant", LastName = "Duncan", Height = 180, DateOfBirth = new DateTime(1933, 06, 19), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 164, FirstName = "Leah", LastName = "Wade", Height = 200, DateOfBirth = new DateTime(1993, 01, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 165, FirstName = "Virgil", LastName = "Gonzalez", Height = 178, DateOfBirth = new DateTime(1954, 10, 08), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 166, FirstName = "Sophia", LastName = "Fleming", Height = 189, DateOfBirth = new DateTime(1983, 05, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 167, FirstName = "Denise", LastName = "Griffin", Height = 154, DateOfBirth = new DateTime(1921, 05, 14), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 168, FirstName = "Hope", LastName = "Medina", Height = 164, DateOfBirth = new DateTime(1992, 11, 03), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 169, FirstName = "Jenny", LastName = "Patton", Height = 174, DateOfBirth = new DateTime(2012, 09, 04), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 170, FirstName = "Tracy", LastName = "James", Height = 191, DateOfBirth = new DateTime(2010, 01, 12), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 171, FirstName = "Paul", LastName = "Walters", Height = 162, DateOfBirth = new DateTime(1959, 11, 25), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 172, FirstName = "Daryl", LastName = "Glover", Height = 183, DateOfBirth = new DateTime(1995, 08, 05), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 173, FirstName = "Lydia", LastName = "Wells", Height = 187, DateOfBirth = new DateTime(1989, 03, 13), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 174, FirstName = "Roderick", LastName = "Garza", Height = 184, DateOfBirth = new DateTime(1997, 11, 10), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 175, FirstName = "Myrtle", LastName = "Russell", Height = 192, DateOfBirth = new DateTime(2009, 12, 26), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 176, FirstName = "Fred", LastName = "Estrada", Height = 178, DateOfBirth = new DateTime(1952, 12, 15), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 177, FirstName = "Jordan", LastName = "Perry", Height = 198, DateOfBirth = new DateTime(1996, 06, 17), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 178, FirstName = "Philip", LastName = "Medina", Height = 185, DateOfBirth = new DateTime(2008, 04, 21), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 179, FirstName = "Emanuel", LastName = "Lamb", Height = 160, DateOfBirth = new DateTime(2016, 11, 22), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 180, FirstName = "Jose", LastName = "Pena", Height = 158, DateOfBirth = new DateTime(1925, 10, 21), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 181, FirstName = "Ervin", LastName = "Hill", Height = 192, DateOfBirth = new DateTime(2008, 09, 19), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 182, FirstName = "Susan", LastName = "Brady", Height = 186, DateOfBirth = new DateTime(1923, 10, 26), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 183, FirstName = "Marsha", LastName = "Ward", Height = 172, DateOfBirth = new DateTime(2008, 11, 29), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 184, FirstName = "Vivian", LastName = "Thomas", Height = 153, DateOfBirth = new DateTime(1980, 05, 23), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 185, FirstName = "Eileen", LastName = "Zimmerman", Height = 192, DateOfBirth = new DateTime(1962, 03, 18), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 186, FirstName = "Geraldine", LastName = "Flowers", Height = 159, DateOfBirth = new DateTime(2003, 03, 15), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 187, FirstName = "Ebony", LastName = "Mclaughlin", Height = 171, DateOfBirth = new DateTime(2006, 02, 13), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 188, FirstName = "Celia", LastName = "Jennings", Height = 197, DateOfBirth = new DateTime(1923, 02, 10), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 189, FirstName = "Carla", LastName = "Goodman", Height = 177, DateOfBirth = new DateTime(1981, 03, 07), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 190, FirstName = "Michelle", LastName = "Conner", Height = 161, DateOfBirth = new DateTime(1976, 10, 06), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 191, FirstName = "Hector", LastName = "Tate", Height = 169, DateOfBirth = new DateTime(1937, 12, 19), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 192, FirstName = "Frank", LastName = "Franklin", Height = 156, DateOfBirth = new DateTime(1977, 12, 02), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 193, FirstName = "Betsy", LastName = "Vargas", Height = 156, DateOfBirth = new DateTime(1968, 02, 01), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 194, FirstName = "Noah", LastName = "Vargas", Height = 181, DateOfBirth = new DateTime(1934, 01, 30), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 195, FirstName = "Tommy", LastName = "Swanson", Height = 196, DateOfBirth = new DateTime(2006, 07, 03), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 196, FirstName = "Dean", LastName = "Mann", Height = 179, DateOfBirth = new DateTime(2016, 12, 10), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 197, FirstName = "Renee", LastName = "Warren", Height = 197, DateOfBirth = new DateTime(1982, 06, 06), Gender = Gender.Female, IsHealthy = false };
            lst.Add(p);
            p = new Person { PersonId = 198, FirstName = "Terry", LastName = "Simpson", Height = 194, DateOfBirth = new DateTime(1942, 05, 11), Gender = Gender.Male, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 199, FirstName = "Cristina", LastName = "Foster", Height = 157, DateOfBirth = new DateTime(2010, 09, 18), Gender = Gender.Female, IsHealthy = true };
            lst.Add(p);
            p = new Person { PersonId = 200, FirstName = "Howard", LastName = "Peterson", Height = 182, DateOfBirth = new DateTime(1927, 02, 14), Gender = Gender.Male, IsHealthy = false };
            lst.Add(p);
            people = lst;
        }
        

        public static List<Person> JustGetPeople(int count = 25)
        {
            return new PersonRepositoryStatic().GetPeople().Take(count).ToList(); ;
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
            people.Add(p);
        }

        public void UpdatePerson(Person p)
        {
            Person np = GetPeople().Find(i => i.PersonId == p.PersonId);
            np.DateOfBirth = p.DateOfBirth;
            np.FirstName = p.FirstName;
            np.Gender = p.Gender;
            np.Height = p.Height;
            np.IsHealthy = p.IsHealthy;
            np.LastName = p.LastName;
        }

        public void DeletePerson(int id)
        {
            people.Remove(people.Find(i => i.PersonId == id));
        }

        public void Dispose()
        {

        }

        private static string GenerateCS(List<Person> lst)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine("var lst = new List<Person>();");
            sb.AppendLine("Person p;");
            foreach (var item in lst)
            {
                string tmp = "p = new Person {{ PersonId = {0},  FirstName = \"{1}\", LastName = \"{2}\", Height = {3}, DateOfBirth = new DateTime({4}), Gender = Gender.{5}, IsHealthy = {6} }};";
                string p = String.Format(tmp, item.PersonId,item.FirstName,item.LastName,item.Height,item.DateOfBirth.ToString("yyyy,MM,dd"), item.Gender, item.IsHealthy?"true":"false");
                sb.AppendLine(p);
                sb.AppendLine("lst.Add(p);");
            }
            return sb.ToString();
        }
    }
}
