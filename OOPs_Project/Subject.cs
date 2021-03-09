using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
    class Subject : Teacher, Print
    {
        public string Nameofsub { get; set; }
        public string Subjectcode { get; set; }

        public Teacher Teacher { get; set; }

        public string getinfo()
        {
            return this.Teacher.Name + ", " + "Class -" + this.Teacher.Class + ", " + "Section -" + this.Teacher.section + ", " + "Subject -" + this.Nameofsub + ", " + "Subject Code -" + this.Subjectcode;
        }
    }
}