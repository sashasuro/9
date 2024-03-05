using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    abstract class Person
    {
        string name;
        string surname;
        DateTime bd = new DateTime(2, 2, 2000);
        public Person()
        {
            DateTime now = DateTime.Now;
            TimeSpan dt = now - bd;
        }
    }
}
