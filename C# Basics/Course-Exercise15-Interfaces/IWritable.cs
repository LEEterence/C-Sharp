//Create an interface called IWritable that can be used with classes that represent creative works. The interface should define two methods - GetNameOfWork() and GetWriter().

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Exercise15
{
    interface IWritable
    {
        string GetNameOfWork();
        string GetWriter();
    }
}
