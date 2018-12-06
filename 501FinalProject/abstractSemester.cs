using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    abstract class abstractSemester
    {
        public abstract string[] Semester(string section);

        public string[] csvs = new string[25];

        public char[] t = new char[1];
        
    }
}
