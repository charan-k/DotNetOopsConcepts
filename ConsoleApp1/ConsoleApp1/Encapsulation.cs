using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Encapsulation
    {
        internal int _id=20;
        protected internal string? _name;
        protected  int employeeId;
        protected  string? firstName;
        protected  string? lastName;
        protected string Name
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
    }
}
