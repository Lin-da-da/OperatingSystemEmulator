using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devices
{
    /// <summary>
    /// 模拟处理器
    /// </summary>
    public class Processer : Device
    {
        public class Process
        {
            public string Name { get; set; }
            public Func<object> Method { get; set; }
            public object Result { get; set; }
            public Process(string name, Func<object> method, object result)
            {
                Name = name;
                Method = method;
                Result = result;
            }
        }

        private List<Process> ProcessList;
        
        public Processer()
        {
            ProcessList = new List<Process>();
        }

        public void AddProcess(Process process)
        {
            ProcessList.Add(process);
        }

        public void RemoveProcess(Process process)
        {
            ProcessList.Remove(process);
        }

        public void Run()
        {
            Hashtable processResult = new Hashtable();
            foreach (var process in ProcessList)
            {
                processResult.Add(process.Name, process.Method());
            }
        }
    }
}
