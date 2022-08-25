using System;
using System.Collections.Generic;
using System.Text;

namespace Test.classes
{
    class Person
    {
        public string Name;
        public int Age;
        public string Adress;

        public Person(string name, int age, string adress)
        {
            Name = name;
            Age = age;
            Adress = adress;
        }

        public override string ToString()
        {
            return Name + " " + Age + " " + Adress;
        }
    }
}
