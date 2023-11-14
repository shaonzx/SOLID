using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O
{
    public class Manager : Employee
    {
        public override int CalculateBonusAbstract(int baseSalary)
        {
            return (int)(baseSalary * 0.6);
        }
    }
}
