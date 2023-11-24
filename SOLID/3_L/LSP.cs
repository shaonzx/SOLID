using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3_L
{
    /*
     * Subtypes must be substitutable for their base type.
     *
     * # Objects of a parent class should be able to be replaced with objects of a child class without affecting the program.
     * # Object of child should be able to access the all the methods and properties of the parent class.
     * # All the base class methods should be applicable for child classes.
     */

    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public DateTime GetLastPurchaseDate()
        {
            return new DateTime(); // a date from database
        }
    }

    //This is a violation of LSP, Leads doesn't have a last purchase date
    public class Lead : Customer
    {

    }

    public interface ILead
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public interface ICustomer : ILead
    {
        public DateTime GetLastPurchaseDate();
    }

    public class MyCustomer : ILead
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }

    public class MyCustomer2 : ICustomer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime GetLastPurchaseDate()
        {
            throw new NotImplementedException();
        }
    }


    internal class LSP
    {
        public void RunTheShow()
        {
            Customer c = new Lead();
            c.GetLastPurchaseDate();
        }
    }
}
