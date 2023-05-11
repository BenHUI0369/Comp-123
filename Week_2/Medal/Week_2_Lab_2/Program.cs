using System.Drawing;
using System.IO;

namespace Week_2_Lab_2
{
    enum MedalColor { Bronze, Silver, Gold}
    class Medal
    {
        public string Name { get; }
        public string TheEvent { get; }
        public MedalColor Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }
        public Medal (string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }
        public override string ToString()
        {
            string recordSymbol = IsRecord ? "(R)":"" ;
            return $"{Year} - {TheEvent}{recordSymbol} Narendra({Color})";
        }
        static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);

            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            //print the updated m2
            Console.WriteLine(m2);
            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1:D2}. {medals[i]}");
            }
            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            for (int i = 0; i < medals.Count; i++)
            {
                Console.WriteLine($"{i + 1:D2}. {medals[i].Name}");
            }
            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            int numberCount = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{++numberCount:D2}. {medal}");
                }
            }
            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");
            numberCount = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].Year == 2012)
                {
                    Console.WriteLine($"{++numberCount:D2}. {medals[i]}");
                }
            }
            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            numberCount = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].Year == 2012 && medals[i].Color == MedalColor.Gold)
                {
                    Console.WriteLine($"{++numberCount:D2}. {medals[i]}");
                }
            }
            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            numberCount = 0;
            for (int i = 0; i < medals.Count; i++)
            {
                if (medals[i].IsRecord == true)
                {
                    Console.WriteLine($"{++numberCount:D2}. {medals[i]}");
                }
            }
            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter writer = new StreamWriter("../../../Medals.txt");
            foreach (Medal medal in medals)
            {
                writer.WriteLine(medal);
            }
            writer.Close();
        }
    }
}