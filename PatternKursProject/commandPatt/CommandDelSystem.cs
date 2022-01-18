using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternKursProject.commandPatt
{
    class CommandDelSystem : Command
    {

        private MonitoringSystem centre;
        private int del=0;
        public int execute()
        {
            centre.delAnalysisSystem(del);
            return del;

        }
        public CommandDelSystem(int n)
        {
            centre = MonitoringSystem.getInstance();
            del = n;
        }
    }
}

