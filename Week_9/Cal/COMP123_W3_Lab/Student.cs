using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W3_Lab
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Sex { get; set; }
        public string Phone { get; set; }
        public Student()
        {
        }

        public Student(int id, string name, bool sex, string phone)
        {
            Id = id;
            Name = name;
            Sex = sex;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"({Id}) {Name} {Phone} {Sex}";
        }
    }
}
