using System;
using System.Collections.Generic;
using System.Text;

namespace Test.classes
{
    class Spørgeskema
    {
        public string PetName;
        public string FavourtieFood;
        public string Music;
        public string Hobby;
        public int Age;

        public Spørgeskema(string petName, string favouriteFood, string music, string hobby, int age)
        {
            PetName = petName;
            FavourtieFood = favouriteFood;
            Music = music;
            Hobby = hobby;
            Age = age;
        }
        public override string ToString()
        {
            return PetName + " " + FavourtieFood + " " + Music + " " + Hobby + " " + Age;
        }
    }
}
