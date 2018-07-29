using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyword.source
{
    class customer
    {

        string name { get; set; }
        int age { get; set; }

        public customer(string _name, int _age)
        {
            name = _name;
            age = _age;
        }
    }
}
