using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PracticeProblems
{
    public class PersonAge
    {
        public string AgeCategory(int age)
        {
            try
            {
                if (age >= 1 || age <= 14)
                {
                    return "Children";
                }
                else if (age >= 15 || age <= 24)
                {
                    return "Youth";
                }
                else if (age >= 25 || age <= 64)
                {
                    return "Adult";
                }
                else if (age >= 65)
                {
                    return "Seniors";
                }
                else
                    return default;
            }
            catch(Exception)
            {
                throw new HandleExceptionAge(HandleExceptionAge.ExceptionType.NULL, "Age is Null");
            }
        }
    }
}
