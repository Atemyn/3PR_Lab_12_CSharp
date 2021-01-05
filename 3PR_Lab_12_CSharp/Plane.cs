using System;
using System.Collections.Generic;
using System.Text;

namespace _3PR_Lab_12_CSharp
{
    class Plane : InterfaceFlyable
    {
        private string name;

        public Plane()
        {
            name = "Unknown";
        }

        public Plane(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine("Самолет с названием " + name + " вылетел.");
        }
    }
}
