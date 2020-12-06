using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_GenericHelper.CustomException
{
    public class NotSuiteableDriverFound :Exception
    {
        
        public NotSuiteableDriverFound(string msg) :base(msg)
        {

        }
    }
}
