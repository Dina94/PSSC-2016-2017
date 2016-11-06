using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Activity
    {
        public String name { get; internal set; }

        internal Activity(String denumire)
        {
            name = denumire;
        }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}