using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es16_05
{
    internal abstract class CaseHandler : IGreet
    {
        protected CaseHandler? NextCheck;

        public CaseHandler SetSuccessor(CaseHandler nextCheck)
        {
            NextCheck = nextCheck;
            return NextCheck;
        }

        public abstract string Greet(string[] names);
        
        
    }  
}
