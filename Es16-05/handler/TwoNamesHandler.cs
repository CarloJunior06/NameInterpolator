using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    internal class TwoNamesHandler : CaseHandler
    {
        public override string Greet(string[] names)
        {
            if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}.";
            }
            else if (NextCheck != null)
            {
                return NextCheck.Greet(names);
            }
            return "";
        }
    }
}   
