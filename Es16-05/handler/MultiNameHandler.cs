using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05.handler
{
    internal class MultiNameHandler : CaseHandler
    {
        public override string Greet(string[] names)
        {
            if (names.Length > 2)
            {
                StringBuilder greeting = new StringBuilder("Hello");
                for (int i = 0; i < names.Length; i++)
                {
                    if (i == 0)
                    {
                        greeting.Append(" ");
                    }
                    else if (i == names.Length - 1)
                    {
                        greeting.Append(" and ");
                    }
                    else
                    {
                        greeting.Append(", ");
                    }
                    greeting.Append(names[i]);
                }
                greeting.Append(".");
                return greeting.ToString();
            }
            {
                return NextCheck.Greet(names);
            }
            return "";
        }

    }
}   
