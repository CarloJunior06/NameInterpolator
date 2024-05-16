using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    internal class NullHandler : CaseHandler
    {
        public override string Greet(string[] names)
        {
            if (names.Length == 0 || names[0] == null)
            {
                return "Hello, my friend.";
            }
            else if (NextCheck != null)
            {
                return NextCheck.Greet(names);
            }
            return "";
        }
    }

}
