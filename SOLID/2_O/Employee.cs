using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2_O
{
    /*
     * OCP - Software entities (classes, modules, functions, etc.)
     * should be open for extension but closed for modification.
     */
    public abstract class Employee
    {
        public int EmployeeType { get; set; }

        /**
         * Following method receives the base salary and returns bonus based on Employee type.
         * Its a violation of OCP as we need to add more if conditions for each new employee types
         */
        public int CalculateBonus(int baseSalary)
        {
            if (EmployeeType == 1)
            {
                return (int)Math.Round(baseSalary * 0.3);
            }

            if (EmployeeType == 2)
            {
                return (int)Math.Round(baseSalary * 0.4);
            }

            return 0;
        }

        /*
         * So, the purpose is keeping changes to minimal, which can be done in many ways.
         * Here I'm doing through an abstract class (can be done with interface as well).
         * So with every new type of employee, they should implement the base Employee
         * and provide their own implemention of CalculateBonusAbstract method.
         */
        public abstract int CalculateBonusAbstract(int baseSalary);
    }
}
