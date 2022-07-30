using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2
{
    internal class Person
    {

        private string name; // field
        public string Name   // property
        {
            get { 
                return name.ToUpper(); 
            }   // get method
            set { name = value; }  // set method
        }

        public int Age { get; set; }

    }
}
