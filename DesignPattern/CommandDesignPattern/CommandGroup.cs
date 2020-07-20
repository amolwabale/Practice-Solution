using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class CommandGroup
    {
        private List<IExecuter> _cmdList = new List<IExecuter>();

        public void AddCommand(IExecuter cmd)
        {
            _cmdList.Add(cmd);
        }

        public void ExecuteCommand()
        {
            foreach (var cmdObj in _cmdList)
            {
                cmdObj.Execute();
            }
        }
    }
}
