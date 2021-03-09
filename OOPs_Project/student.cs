using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
    class Student : Print
    {
        public string Name { get; set; }

        public int Class { get; set; }
        public string Section { get; set; }


        public string getinfo()
        {
            return this.Name + ", " + this.Class + ", " + this.Section;
        }

        public string gettypeofperson()
        {
            return "Student";
        }
    }
}