using System;
using System.Collections.Generic;
using System.Text;

namespace Test.classes
{
    class Pet
    {
        public string Type;
        public string Name;
        public int Age;
        public string Breed;
        public Person Owner;


        public Pet(string type, string name, int age, string breed, Person owner)
        {
            Type = type;
            Name = name;
            Age = age;
            Breed = breed;
            Owner = owner;
        }

        //public override string ToString()
        //{
        //    string ownersToME = "";
        //    for (int i = 0; i < ownersToME.Count; i++)
        //    {
        //        ownersToME += ownersToME[i].ToString() + "\n";
        //    }
        //    return Name + "\n " + ownersToME;
        //}
    }
}
