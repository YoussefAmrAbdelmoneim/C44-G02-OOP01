using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmet_1_oop
{
    [Flags]
    internal enum Permissions
    {
        Read =1,
        Write =2,
        Delete =4,
        Execute = 8
    }
}
