using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._1_S
{
    internal class ErrorHandler
    {
        public void Handle(Exception ex)
        {
            System.IO.File.WriteAllText(@"c:\errors.txt", ex.Message);
        }
    }
}
