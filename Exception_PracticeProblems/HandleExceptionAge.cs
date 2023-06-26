using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PracticeProblems
{
    public class HandleExceptionAge : Exception
    {
        public enum ExceptionType
        {
            NULL,EMPTY
        }
        public ExceptionType Type { get; set; }
        public HandleExceptionAge(ExceptionType Type,string message):base(message)
        {
            this.Type = Type;
        }
    }
}
