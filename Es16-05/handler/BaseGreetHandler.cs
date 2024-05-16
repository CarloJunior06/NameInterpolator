using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    internal class BaseGreetHandler : CaseHandler
    {
        public override string Greet(string[] names)
        {
            if (names?.Length == 1 && names[0] != null)
            {
                return $"Hello, {names[0]}.";
            }
            return NextCheck.Greet(names);
        }
    }

}
