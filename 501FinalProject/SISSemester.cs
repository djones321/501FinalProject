using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class SISSemester : abstractSemester
    {
        
        public override string[] Semester(string section)
        {
            this.t[0] = ',';
            this.csvs = section.Split(t);
            
            return this.csvs;
        }
    }
}
