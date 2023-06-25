using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel.Programs
{
    public class MlangParaser
    {
        private bool initialized = false;
        
        public string script { get; private set; }
        public string[]? lines { get; private set; }


        private Dictionary<string, dynamic> parameters;

        public MlangParaser(string _script)
        {
            initialized = true;

            this.script = _script;
            parameters = new Dictionary<string, dynamic>();
            lines = script.Split('\n');
            
        }



    }
}
