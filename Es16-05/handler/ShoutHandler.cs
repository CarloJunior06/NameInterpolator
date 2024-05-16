using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    internal class ShoutHandler : CaseHandler
    {
        public override string Greet(string[] names)
        {
            if (names.Length == 1 && names[0].Equals(names[0].ToUpper()))
            {
                return $"HELLO {names[0]}!";
            }
            else if (NextCheck != null)
            {
                return NextCheck.Greet(names);
            }
            return "";
        }
    }
}
