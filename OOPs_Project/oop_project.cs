using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
    class Project
    {
        public static void Do()
        {
            Student[] s = new Student[3];
            Teacher[] t = new Teacher[3];
            Subject[] su = new Subject[3];
            for (int i = 0; i < 3; i++)
            {
                s[i] = new Student();
                t[i] = new Teacher();
                su[i] = new Subject();
            }
            s[0].Name = "Harshit Pradhan";
            s[0].Class = 11;
            s[0].Section = "A";
            s[1].Name = "Suraj Purohit";
            s[1].Class = 12;
            s[1].Section = "B";
            s[2].Name = "Sachin samant";
            s[2].Class = 9;
            s[2].Section = "A";
            t[0].Name = "Mr.Lalit Kane";
            t[0].Class = 11;
            t[0].section = "A";
            t[1].Name = "Mr.krishna";
            t[1].Class = 11;
            t[1].section = "B";
            t[2].Name = "Mr. xyz";
            t[2].Class = 10;
            t[2].section = "B";
            su[0].Nameofsub = "Physics";
            su[0].Subjectcode = "01";
            su[0].Teacher = t[0];
            su[1].Nameofsub = "Biology";
            su[1].Subjectcode = "02";
            su[1].Teacher = t[1];
            su[2].Nameofsub = "Maths";
            su[2].Subjectcode = "03";
            su[2].Teacher = t[2];
            Console.WriteLine("Students in a class \n");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(s[i].getinfo());
            Console.Write("\n");
            Console.WriteLine("Subjects taught by Teacher");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(su[i].getinfo());
        }
    }
}