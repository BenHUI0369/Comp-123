using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace COMP123_W4_L2
{
    class Program
    {
        public static string FIRSTLINE_XML = "FIRST_LINE.xml";
        public static string FIRSTLINE_JSON = "FIRST_LINE.json";
        public static string ALLLINE_XML = "ALL_LINE.xml";
        public static string ALLLINE_JSON = "ALL_LINE.json";
        public static readonly List<Atom> elements = Atom.GetAtom();
        public static void Main(string[] args)
        {
            static void WriteJson(List<Atom> atoms, string filename)
            {
                File.WriteAllText(filename, JsonSerializer.Serialize(atoms));
            }

            static void ReadJson(string filename)
            {
                StreamReader streamReader = new StreamReader(filename);
                TextReader reader = new StreamReader(filename);
                Atom atom = JsonSerializer.Deserialize<Atom>(reader.ReadToEnd());
                reader.Close();
            }
            XmlSerialize();
            XmlDeserialize(FIRSTLINE_XML);
            JsonSerialize();
            JsonDeserialize(FIRSTLINE_JSON);
            XmlSerializeAll();
            XmlDeserializeAll(ALLLINE_XML);
            JsonSerializeAll();
            JsonDeserializeAll(ALLLINE_JSON);
        }

        //Create class methods to do the following:

        //1 - Display all the items in the collection elements
        static void DisplayAtoms(List<Atom> atomList)
        {
            foreach (var atom in atomList)
            {
                Console.WriteLine(atom);
            }
        }
        //2 - Serialize the first item using xml format and save to a suitable file
        static void XmlSerialize()
        {
            //use XmlSerializer to create serializer for XML file with defined type inside typeof() (in this case, it is Atom class)
            XmlSerializer serializer = new XmlSerializer(typeof(Atom));
            //call streamwriter to write thing in to .xml file
            StreamWriter writer = new StreamWriter(FIRSTLINE_XML);
            //using serializer(which assigned previously) to create serializer xml file with class<element[0]>(in this cals, element[0] is Atom class)
            serializer.Serialize(writer, elements[0]);
            //close the writer for security
            writer.Close();
        }
        //3 - Read the above file and display the item
        static void XmlDeserialize(string fileName)
        {
            //use XmlSerializer to create serializer for XML file with defined type inside typeof()
            XmlSerializer xmlSer = new XmlSerializer(typeof(Atom));
            //call StreamReader to read .xml file
            StreamReader reader = new StreamReader(fileName);
            //base on the reading class(in this case, one line xml file is class Atom), use Deserialize method to read the file and transfer it into class.
            Atom atom = (Atom)xmlSer.Deserialize(reader);
            //print the output (since it is Atom class, it will follow the ToString method we overrided in Atom.cs)
            Console.WriteLine(atom);
            //close the reader for security
            reader.Close();
        }
        //4 - Serialize the entire collection using xml format and save to a suitable file 
        static void XmlSerializeAll()
        {
            //use XmlSerializer to create serializer for XML file with defined type inside typeof() (in this case, it is List<Atom> class)
            XmlSerializer serializer = new XmlSerializer(typeof(List<Atom>));
            //call streamwriter to write thing in to .xml file
            StreamWriter writer = new StreamWriter(ALLLINE_XML);
            //using serializer(which assigned previously) to create serializer xml file with class<element>(in this cals, element is List<Atom> class)
            serializer.Serialize(writer, elements);
            //close the writer for security
            writer.Close();
        }
        //5 - Read the above file and display the all the items
        static void XmlDeserializeAll(string fileName)
        {
            //use XmlSerializer to create serializer for XML file with defined type inside typeof()
            XmlSerializer xmlSer = new XmlSerializer(typeof (List<Atom>));
            //call StreamReader to read .xml file
            StreamReader reader = new StreamReader (fileName);
            //base on the reading class(in this case, one line xml file is class List<Atom>), use Deserialize method to read the file and transfer it into class.
            List<Atom> atoms = (List<Atom>)xmlSer.Deserialize(reader);
            //print the output (since it is List<Atom> class, and we use the DisplayAtom method we created to print it. go to question 1 to find the method)
            DisplayAtoms(atoms);
            //close the reader for security
            reader.Close();
        }
        //6 - Serialize the first item using json format and save to a suitable file
        static void JsonSerialize()
        {
            //use JsonSerializer with method Serialize(class) to create json string (in this case, element[0] is class Atom)
            string jsonString = JsonSerializer.Serialize(elements[0]);
            //use file with WriteAllText method to write all json string to file.
            File.WriteAllText(FIRSTLINE_JSON, jsonString);
        }
        //7 - Read the above file and display the item
        static void JsonDeserialize(string fileName)
        {
            //call StreamReader to read json file
            StreamReader reader = new StreamReader(fileName);
            //base on the reading class(in this case, one line json file is class Atom), use Deserialize method to read the file and transfer it into class.
            Atom jasonAtom = JsonSerializer.Deserialize<Atom>(reader.ReadToEnd());
            //print the output (since it is Atom class, it will follow the ToString method we overrided in Atom.cs)
            Console.WriteLine(jasonAtom);
            //close the reader for security
            reader.Close();
        }
        //8 - Serialize the entire collection using json format and save to a suitable file 
        static void JsonSerializeAll()
        {
            //use JsonSerializer with method Serialize(class) to create json string (in this case, element is class List<Atom>)
            string jsonString = JsonSerializer.Serialize(elements);
            //use file with WriteAllText method to write all json string to file.
            File.WriteAllText(ALLLINE_JSON, jsonString);
        }
        //9 - Read the above file and display all the items
        static void JsonDeserializeAll(string fileName)
        {
            //call StreamReader to read json file
            StreamReader reader = new StreamReader(fileName);
            //base on the reading class(in this case, all line json file is class List<Atom>), use Deserialize method to read the file and transfer it into class.
            List<Atom> jasonAtom = JsonSerializer.Deserialize<List<Atom>>(reader.ReadToEnd());
            //print the output (since it is List<Atom> class, and we use the DisplayAtom method we created to print it. go to question 1 to find the method)
            DisplayAtoms(jasonAtom);
            //close the reader for security
            reader.Close ();
        }
    }
}