using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class Section
    {
        public static string Sections(string[] localCSV, string[] ksisCSV)
        {
            //section off the important info and run various comparisons
            string errorList = "";
            int i;
            for (i = 0; i < 4; i++)
            {
                if (localCSV == null || ksisCSV == null)
                {
                    errorList = "section was null";
                }
                else if (!Course.compare(localCSV[i], ksisCSV[i]))
                {
                    errorList = "Section "+ksisCSV[0]+" " + ksisCSV[1]+" Section" + ksisCSV[3] + " not found in current semester!";
                }
            }
            return errorList;
        }
    }
}
