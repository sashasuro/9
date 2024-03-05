using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Enrollee
    {
        string name = "Oleg";
        string surname = "Voronov";
        DateTime bd = new DateTime(9, 5, 1998);
        string faculty = "Arts";
    }
    class Student
    {
        string name = "Alexander";
        string surname = "Kurp";
        DateTime bd = new DateTime(6, 12, 2006);
        string faculty = "Historical";
        int kurs = 3;
    }
    class Teacher
    {
        string name = "Vlad";
        string surname = "Norikov";
        DateTime bd = new DateTime(21, 7, 1991);
        string faculty = "Economic";
        string jt = "Teacher";
        int experience = 3;
    }
}
