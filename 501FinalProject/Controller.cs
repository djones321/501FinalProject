using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _501FinalProject
{
    class Controller
    {
        static abstractSemester localSemester = new localSemestser();
        static abstractSemester ksisSemester = new SISSemester();
        static string[] localStrings = new string[99];
        private static string[] KSISStrings = new string[99];

        public static string Load(string filePath)
        {
            int i = 0;
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            sr.ReadLine();
            string line = sr.ReadLine();
            
            while (line != null)
            {
                localStrings[i] = line;
                i++;
                line = sr.ReadLine();
            }
            sr.Close();
            StringBuilder sb = new StringBuilder();

            foreach (string s in localStrings)
            {
                sb.Append(s);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
            
        }
        

        public static string Verify(string filePath)
        {
            
            int i = 0;
            StreamReader sr = new StreamReader(filePath);
            sr.ReadLine();
            sr.ReadLine();
            string line = sr.ReadLine();
            while (line != null)
            {
                KSISStrings[i] = line;
                i++;
                line = sr.ReadLine();
            }

            sr.Close();

            StringBuilder errorList = new StringBuilder();
            string result = "";
            
            for(i = 0; i < localStrings.Length; i++)
            {
                if(localStrings[i] == null) continue;
                for (int j = i; j < i+2; j++)
                {
                    if (KSISStrings[j] == null) continue;
                    result = Section.Sections(localSemester.Semester(localStrings[i]),
                        ksisSemester.Semester(KSISStrings[j]));
                    
                    if (result == "") break;
                }

                if (result != "")
                {
                    errorList.Append(result);
                    errorList.Append(Environment.NewLine);
                }
            }
           
            return errorList.ToString();
        }

        public static string Reload(string filePath)
        {
            if (filePath != "") return Verify(filePath);
            else return "";
        }
        
        
    }
}
