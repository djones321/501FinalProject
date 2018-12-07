using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _501FinalProject
{
    class Section
    {
        public static string Sections(string[] localCSV, string[] ksisCSV)
        {
            int count = 0;
            bool sameCourse = false;
            int i;

            if (localCSV == null && ksisCSV == null)
            {
                return "";
            }

            if (localCSV == null)
                return ("Section " + ksisCSV[0] + " " + ksisCSV[1] + " Section " + ksisCSV[3] +
                        " is new this semester");
            if (ksisCSV == null)
                return ("Section " + localCSV[0] + " " + localCSV[1] + " Section " + localCSV[3] + " cannot be found");



                for (i = 0; i < 4; i++)
                {
                    sameCourse = getCourse(localCSV[i], ksisCSV[i]);
                }

                if (!getInstructor(localCSV[4], ksisCSV[4])) count++; //teacher
                if (!getCourse(localCSV[5], ksisCSV[5])) count++; //consent
                if (!getCourse(localCSV[6], ksisCSV[6])) count++; //enrlcap
                if (!getCourse(localCSV[7], ksisCSV[7])) count++; //topic

                for (i = 8; i < 20; i++)
                {
                    if (i == 10) //facility
                    {
                        if (!getFacility(localCSV[i], ksisCSV[i])) count++;
                    }

                    if (!getTime(localCSV[i], ksisCSV[i])) count++;
                }

                if (!getCourse(localCSV[20], ksisCSV[20])) count++; //unitsmin
                if (!getCourse(localCSV[21], ksisCSV[21])) count++; //unitsmax
                if (!getCourse(localCSV[22], ksisCSV[22])) count++; //component



                if (count == 0 && sameCourse) return "";
                else if (sameCourse && count > 0)
                {
                    return ("Section " + ksisCSV[0] + " " + ksisCSV[1] + " Section " + ksisCSV[3] +
                            " has been changed in the current semester");
                }
                else
                {
                    return ("Section " + ksisCSV[0] + " " + ksisCSV[1] + " Section " + ksisCSV[3] +
                            " is new this semester");
                }
        
        }

        public static bool getCourse(string localCSV, string ksisCSV)
        {
            return Course.compare(localCSV, ksisCSV);
        }

        public static bool getInstructor(string localCSV, string ksisCSV)
        {
            return Instructor.compare(localCSV, ksisCSV);
        }

        public static bool getTime(string localCSV, string ksisCSV)
        {
            return Time.compare(localCSV, ksisCSV);
        }

        public static bool getFacility(string localCSV, string ksisCSV)
        {
            return Facility.compare(localCSV, ksisCSV);
        }
    }
}
