﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animals
{
    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string ProduceSound(){
            return "Miaaauuu...";
        }
    }
}
