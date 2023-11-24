using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._5_D
{
    /**
     * High level classes mustn't depend on lower level class
     */

    internal class OutletRepository //High level class
    {
        public void AddOutlet(string outletData)
        {
            /******* Som operations for adding the outlet *******/

            /*
             * Following FileLogger class is a low level class
             * and this is a violation of DIP (and SRP as the same time)
             */
            //FileLogger fl = new FileLogger();
            //fl.Log("Customer added");

            /*
             * Instead doing it, we should Inject the dependency through IFileLogger
             *
             * Dependency Injection is the implementation of Dependency inversion principle
             */
        }
    }
}
