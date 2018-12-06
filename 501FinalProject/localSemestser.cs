using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class localSemestser : abstractSemester
    {
        
        public override string[] Semester(string section)
        {
            this.t[0] = ',';
            if(section == null) return null;
            this.csvs = section.Split(t);

            return this.csvs;
        }
    }
}
