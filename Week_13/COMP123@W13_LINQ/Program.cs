using System.Linq;
using System;

namespace COMP123_W13_LINQ
{
    public class Student
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int Id { get; set; }
        public List<int> Scores;
        public override string ToString()
        {
            return string.Format("{0} {1} - {2} ", First, Last, Id);
        }
        static List<Student> students = new List<Student> {
          new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
          new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
          new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} },
          new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
          new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34,  90} },
          new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
          new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
          new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
          new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
          new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67,  87} },
          new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74,  95} },
          new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67,  49} },
          new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
          new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75,  67} },
          new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92,  68} },
          new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83,  87} },
          new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
        };

    }

    class Fruit
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return string.Format("{0} @{1:c} ({2})", Name, Price, Origin.Substring(0, 2).ToUpper());
        }
        static List<Fruit> fruits = new List<Fruit>()
        {
          new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
          new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
          new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
          new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
          new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
          new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
          new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
          new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
          new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
        };

    }
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool IsFemale { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}B {2} {3} {4}yrs", Name, Asset, IsFemale ? "F" : "M", Country, Age);
        }
        static List<Person> persons = new List<Person>()
        {
          new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
          new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
          new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
          new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
          new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
          new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
          new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
          new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
          new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
          new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
          new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
          new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
          new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
          new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
          new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
          new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
          new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
          new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
          new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
          new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
          new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
          new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
          new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
          new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
          new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
          new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
          new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
          new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
          new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
          new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
          new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
          new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
          new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
          new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
          new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
          new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
          new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
        };

    }


    class PetOwner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


    class Pet
    {
        public string Name { get; set; }
        public PetOwner Owner { get; set; }
    }

    internal class Program
    {
        static List<Student> students = new List<Student> {
          new Student{ First="Xavier", Last="Thomas", Id=111, Scores=new List<int>{97,92 ,81 , 55, 60 } },
          new Student{ First="Lyoid", Last="Lopes", Id=112, Scores=new List<int>{96, 88, 86, 77, 55 } },
          new Student{ First="Navdeep", Last="Singh", Id=113, Scores=new List<int>{92, 97, 65, 89,  45} },
          new Student{ First="Lyle", Last="Spurrell", Id=114, Scores=new List<int>{90, 95, 75, 78, 83 } },
          new Student{ First="Viktor", Last="Salnichenko", Id=115, Scores=new List<int>{87, 96, 65, 34,  90} },
          new Student{ First="Sukhpratap", Last="Singh", Id=116, Scores=new List<int>{90, 87, 56, 98, 78 } },
          new Student{ First="Dannel", Last="Alon", Id=117, Scores=new List<int>{90, 84,59 ,67 , 98 } },
          new Student{ First="Francis", Last="Acheampong", Id=118, Scores=new List<int>{89, 56, 56, 67, 87 } },
          new Student{ First="Mahamod", Last="Masleh", Id=119, Scores=new List<int>{67, 78,46 , 78, 98 } },
          new Student{ First="John", Last="Calma", Id=120, Scores=new List<int>{89, 76, 78, 67,  87} },
          new Student{ First="Sarina", Last="Luu", Id=121, Scores=new List<int>{67, 67, 87, 74,  95} },
          new Student{ First="Valerie", Last="Chan", Id=122, Scores=new List<int>{87, 69, 95, 67,  49} },
          new Student{ First="Tej", Last="Singh", Id=127, Scores=new List<int>{90, 87, 96, 98, 78 } },
          new Student{ First="Mabel", Last="Tang", Id=123, Scores=new List<int>{87, 78,59 , 75,  67} },
          new Student{ First="Rishav", Last="Giri", Id=124, Scores=new List<int>{65, 87, 58, 92,  68} },
          new Student{ First="Toni", Last="Lea", Id=125, Scores=new List<int>{78, 97, 83, 83,  87} },
          new Student{ First="Melanie", Last="March", Id=126, Scores=new List<int>{89, 79, 80, 95, 97 } }
        };
        static List<Fruit> fruits = new List<Fruit>()
        {
          new Fruit(){ Name="Mango", Origin="Guyana", Price=5.67},
          new Fruit(){ Name="Kiwi", Origin="New Zeeland", Price=1.34},
          new Fruit(){ Name="Dragon Fruit", Origin="China", Price=3.45},
          new Fruit(){ Name="Avacado", Origin="Mexico", Price=2.56},
          new Fruit(){ Name="Banana", Origin="Ecuador", Price=0.25},
          new Fruit(){ Name="Persimon", Origin="Spain", Price=1.36 },
          new Fruit(){ Name="Blueberry", Origin="Canada", Price=0.19 },
          new Fruit(){ Name="Strawberry", Origin="Russia", Price=0.45 },
          new Fruit(){ Name="Avocado", Origin="Mexico", Price=0.45 }
        };
        static List<Person> persons = new List<Person>()
        {
          new Person(){ Age = 72, Asset = 7.0, Country="South Africa", IsFemale=false, Name="Nicky Oppenheimer"},
          new Person(){ Age = 67, Asset = 7.6, Country="India", IsFemale=true, Name="Savitri Jindal"},
          new Person(){ Age = 81, Asset = 3.1, Country="India", IsFemale=true, Name="Indu Jain"},
          new Person(){ Age = 70, Asset = 2.5, Country="India", IsFemale=true, Name="Vinod Gupta"},
          new Person(){ Age = 77, Asset = 27.0, Country = "US",IsFemale = true,Name = "Jacqueline Mars"},
          new Person(){ Age = 76, Asset = 25.2, Country = "Italy", IsFemale = true, Name = "Maria Franca Fissolo"},
          new Person(){ Age = 55, Asset = 20.4, Country = "Germany", IsFemale = true, Name = "Susanne Klatten"},
          new Person(){ Age = 53, Asset = 20.0, Country = "US",IsFemale = true,Name = "Laurene Jobs"},
          new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", IsFemale=false, Name="Aliko Dangote" },
          new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", IsFemale=false, Name="Mohammed Al Amoudi"},
          new Person(){ Age = 60, Asset = 30.7, Country = "Canada", IsFemale=false, Name="David Thomson" },
          new Person(){ Age = 76, Asset = 11.4, Country = "Canada", IsFemale=false, Name="Galen Weston"},
          new Person(){ Age = 60, Asset = 22.3, Country = "India", IsFemale=false, Name="Mukesh Ambani"},
          new Person(){ Age = 50, Asset = 17.5, Country = "India", IsFemale=false, Name="Dilip Shanghvi"},
          new Person(){ Age = 83, Asset = 30.4, Country = "US", IsFemale=false, Name="Sheldon Adelson"},
          new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", IsFemale=false, Name="Jorge Lemann"},
          new Person(){ Age = 62, Asset = 18.4, Country = "Russia", IsFemale=false, Name="Leonid Mikhelson"},
          new Person(){ Age = 51, Asset = 17.5, Country = "Russia", IsFemale=false, Name="Alexey Mordashov"},
          new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", IsFemale=false, Name="Li Ka-shing"},
          new Person(){ Age = 62, Asset = 31.2, Country = "China", IsFemale=false, Name="Wang Jianlin"},
          new Person(){ Age = 67, Asset = 33.8, Country = "US", IsFemale=true, Name="Alice Walton" },
          new Person(){ Age = 60, Asset = 34.0, Country = "US", IsFemale=false, Name="Jim Walton"},
          new Person(){ Age = 72, Asset = 34.1, Country = "US", IsFemale=false, Name="Rob Walton"},
          new Person(){ Age = 94, Asset = 39.5, Country = "France", IsFemale=true, Name="Liliane Bettencourt"},
          new Person(){ Age = 43, Asset = 39.8, Country = "US", IsFemale=false, Name="Sergey Brin"},
          new Person(){ Age = 43, Asset = 39.6, Country = "US", IsFemale=false, Name="Larry Page"},
          new Person(){ Age = 68, Asset = 41.5, Country = "France", IsFemale=false, Name="Bernard Arnault"},
          new Person(){ Age = 75, Asset = 47.5, Country = "US", IsFemale=false, Name="Michael Bloomberg"},
          new Person(){ Age = 77, Asset = 48.3, Country = "US", IsFemale=false, Name="David Koch"},
          new Person(){ Age = 81, Asset = 48.3, Country = "US", IsFemale=false, Name="Charles Koch"},
          new Person(){ Age = 72, Asset = 52.2, Country = "US", IsFemale=false, Name="Larry Ellison"},
          new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", IsFemale=false, Name="Carlos Slim Helu"},
          new Person(){ Age = 33, Asset = 56.0, Country = "US", IsFemale=false, Name="Mark Zuckerberg"},
          new Person(){ Age = 81, Asset = 71.3, Country = "Spain", IsFemale=false, Name="Amancio Ortega"},
          new Person(){ Age = 53, Asset = 72.8, Country = "US", IsFemale=false, Name="Jeff Bezos" },
          new Person(){ Age = 85, Asset = 75.6, Country = "US", IsFemale=false, Name="Warren Buffet" },
          new Person(){ Age = 60, Asset = 86.0, Country = "US", IsFemale=false, Name="Bill Gates"}
        };
        static void Main(string[] args)
        {

            //selects all data objects from the strongly typed 
            //collection persons. The result of the query
            // is of type IEnumerable<Person>
            var r1 = from p in persons select p;

            //filters only female. Notice we are re-using the variable r1, the return types of the query are the same
            r1 = from p in persons where p.IsFemale select p;

            //only US citizens
            r1 = from p in persons where p.Country == "US" select p;

            //last name begins with "W"
            r1 = from p in persons where p.Name.Split()[0] == "W" select p;

            //ordering by age
            r1 = from p in persons orderby p.Age select p;

            //order by last name
            r1 = from p in persons orderby p.Name.Split()[1] select p;

            //order by last name then first name
            r1 = from p in persons orderby p.Name.Split()[1], p.Name.Split()[0] select p;

            //------------Grouping
            //grouping according to age buckets
            //The result of the query is of type
            //IEnumerable<IGrouping<string, Person>>
            var r3 = from p in persons
                     group p by p.IsFemale;


            //-----------Projections
            //The following returns a query of type IEnumerable<string>
            var r4 =
              from p in persons
              where p.Country == "US"
              select p.Name;

            int[] numbers = { 2, 3, 4, 5 };
            //the following returns a query of type IEnumerable<a>
            var r5 =
            from x in numbers
            select new { Radius = x, Area = Math.PI * x * x };

            //1.Select all the persons with assets of over 50B dollars.
            Console.WriteLine($"1.Select all the persons with assets of over 50B dollars");
            Console.WriteLine($"--------------------------------------------------------");
            var richPeople = from p in persons 
                             where p.Asset > 50 
                             select p;

            foreach (var person in richPeople)
            {
                Console.WriteLine($"{person}");
            }
            Console.WriteLine();
            //2.Select all non-US citizens.
            Console.WriteLine($"2.Select all non-US citizens.");
            Console.WriteLine($"--------------------------------------------------------");
            var nonUSCitizens = from p in persons 
                                where p.Country != "US" 
                                select p;

            foreach (var person in nonUSCitizens)
            {
                Console.WriteLine($"{person}");
            }
            Console.WriteLine();
            //3.Select the name of all the females from India. Your query should only capture the person’s name. (This is a projection query)
            Console.WriteLine($"3.Select the name of all the females from India.");
            Console.WriteLine($"--------------------------------------------------------");
            var indiaFemales = from p in persons 
                               where p.Country == "India" && p.IsFemale 
                               select p.Name;

            foreach (var person in indiaFemales)
            {
                Console.WriteLine($"{person}");
            }
            Console.WriteLine();
            //4.Select all persons whose first name is less than five letters long.
            Console.WriteLine($"4.Select all persons whose first name is less than five letters long.");
            Console.WriteLine($"--------------------------------------------------------");
            var personFirstName = from p in persons 
                                  where p.Name.Split(' ')[0].Length < 5 
                                  select p;

            foreach (var person in personFirstName)
            {
                Console.WriteLine($"{person}");
            }
            Console.WriteLine();
            //5.Sort the collection by assets. Your query should only capture the person’s name and asset.
            Console.WriteLine($"5.Sort the collection by assets. Your query should only capture the person’s name and asset.");
            Console.WriteLine($"--------------------------------------------------------");
            var sortedAssest = from p in persons 
                               orderby p.Asset 
                               select new { p.Name, p.Asset };

            foreach (var person in sortedAssest)
            {
                Console.WriteLine($"{person}");
            }
            Console.WriteLine();
            //6.Group the collection by country.
            Console.WriteLine($"6.Group the collection by country.");
            Console.WriteLine($"--------------------------------------------------------");
            var query6 = from person in persons
                         group person by person.Country into countryGroup
                         select new { Country = countryGroup.Key, Persons = countryGroup.ToList() };

            foreach (var group in query6)
            {
                Console.WriteLine($"Country: {group.Country}");
                foreach (var person in group.Persons)
                {
                    Console.WriteLine($"{person}");
                }
                Console.WriteLine();
            }
            //7.Sort the above grouping.
            Console.WriteLine($"7.Sort the above grouping.");
            Console.WriteLine($"--------------------------------------------------------");
            var query7 = from person in persons
                         orderby person.Country, person.Name
                         group person by person.Country into countryGroup
                         select new { Country = countryGroup.Key, Persons = countryGroup.ToList() };

            foreach (var group in query7)
            {
                Console.WriteLine($"Country: {group.Country}");
                foreach (var person in group.Persons)
                {
                    Console.WriteLine($"\t{person.Name}");
                }
            }
            //8.Make up three queries of your own.
            //8.1
            Console.WriteLine($"8_1. Last name start with M");
            Console.WriteLine($"--------------------------------------------------------");
            var query8_1 = from person in persons
                           let lastName = person.Name.Split().Last()
                           where lastName.StartsWith("M")
                           select person;

            foreach (var person in query8_1)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine();
            // Query 8.2: Select the top 3 persons with the highest assets.
            Console.WriteLine($"8_2. Select the top 3 persons with the highest assets.");
            Console.WriteLine($"--------------------------------------------------------");
            var query8_2 = (from person in persons
                            orderby person.Asset descending
                            select person).Take(3);

            foreach (var person in query8_2)
            {
                Console.WriteLine($"{person.Name} has {person.Asset} dollars in assets.");
            }
            Console.WriteLine();

            // Query 8.3: Group the collection by gender and country, and calculate the average assets for each group.
            Console.WriteLine($"8_3. Group the collection by gender and country, and calculate the average assets for each group.");
            Console.WriteLine($"--------------------------------------------------------");
            var query8_3 = from person in persons
                           group person by new { person.IsFemale, person.Country } into genderCountryGroup
                           select new { genderCountryGroup.Key, AverageAssets = genderCountryGroup.Average(p => p.Asset) };

            foreach (var group in query8_3)
            {
                Console.WriteLine($"Gender: {(group.Key.IsFemale ? "Female" : "Male")}, Country: {group.Key.Country}, Average Assets: {group.AverageAssets:c2}B");
            }
            Console.WriteLine();
        }
    }
}