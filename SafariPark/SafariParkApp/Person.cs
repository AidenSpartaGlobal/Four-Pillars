﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person
    {
        public string FirstName { get; init; } = "";
        public string LastName { get; init; } = "";
        private int _age;
        public int Age 
        {
            get { return _age; }
            set 
            {
                if(value < 0 || value > 99)
                {
                    throw new ArgumentException("Out of Range");
                }
                _age = value;          
            } 
        }

        public Person() { }

        public Person(string firstName, string lastName, int age = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName)
        {
            FirstName = firstName;
        }

   

        //public string FullName => $"{FirstName} {LastName}";

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name: {GetFullName()} Age : {Age}";
           
        }
    }
}
